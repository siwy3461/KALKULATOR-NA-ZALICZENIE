using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return; 
            }

            String  wynik;
            double av, bv, wynik1 = 0;
            int o=0;

            av = Convert.ToDouble(textBox1.Text);
            bv = Convert.ToDouble(textBox2.Text);
           
            if (label7.Text == "-") //liczba a
            {
                av = av * -1;
           
            }

            if (label6.Text == "-") // liczba b
            {
                bv = bv * -1;

            }

            switch (label1.Text)
            {
                case ("DODAWANIE"):
                    wynik1 = av + bv;

                    break;
                case ("ODEJMOWANIE"):
                    wynik1 = av - bv;

                    break;
                case ("MNOŻENIE"):
                    wynik1 = av * bv;
                    break;

                case ("DZIELENIE"):
                    if (bv==0)
                    {
                        MessageBox.Show("NIE WOLNO DZIELIC PRZEZ 0");
                    break;}
                    else
                    { wynik1 = av / bv;};
                   
                      break;

                case ("POTĘGOWANIE"):
                    wynik1 = Math.Pow(av, bv);
                    break;

                case ("PIERWIASTEK"):
                    wynik1 = Math.Sqrt(av);
                    break;
                    
                default:
                    MessageBox.Show("NIC NIE WYBRAŁEŚ");
                    o=1;
                    break;
                                }

            switch (textBox5.Text)
            {
                case ("TRYB INŻYNIERSKI"):
                    if (label1.Text == "WYBIERZ DZIAŁANIE")
                    {
                        MessageBox.Show("Wybierz działanie!");
                    }
                    else { 
                    MessageBox.Show("Wybrałeś tryb inżynierski, teraz musisz sam sobie obliczyć.\n  Wykonaj " + label1.Text + " na liczbach " + textBox1.Text + " oraz " + textBox2.Text + ".");
            }

                    break;

                                        
                default:

                   if (o==1)
                   { 
                       textBox3.Text = "WYNIKU BRAK";
                   }
                   else
                   {
                    wynik = wynik1.ToString("0.###");
                    textBox3.Text = wynik;
                  
                   }
                   break;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "DODAWANIE";
            button1.ForeColor = Color.Red;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            textBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "ODEJMOWANIE";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Red;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            textBox2.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "MNOŻENIE";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Red;
            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            textBox2.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "DZIELENIE";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Red;
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            textBox2.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" )
            {
                textBox5.Text = "TRYB INŻYNIERSKI";
                button5.ForeColor = Color.Red;
            }
               else
            {
                textBox5.Text = "";
                button5.ForeColor = Color.Black;

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "+";
            label7.Text = "+";


        }

        private void button7_Click(object sender, EventArgs e)
        { 
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uruchom sobie kalkulator albo Excela...");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label1.Text = "WYBIERZ DZIAŁANIE";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            textBox5.Text = "";
            button5.ForeColor = Color.Black;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "";
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            textBox2.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\OneDrive Studia\OneDrive - The Opole University of Technology\PROJEKTY\ConsoleApplication1\Release\kalk90.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //liczba A
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == ',' ? textBox1.Text.Contains(',') == true : true))
                e.Handled = true;

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //liczba B
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == ',' ? textBox2.Text.Contains(',') == true : true))
                e.Handled = true;

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label1.Text = "POTĘGOWANIE";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Red;
            button10.ForeColor = Color.Black;
            MessageBox.Show("W tym wypadku liczba 'A' jest podstawą potęgi, a liczba 'B' jej wykładnikiem. Do Dzieła!");
            textBox2.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "PIERWIASTEK";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button10.ForeColor = Color.Red;
            MessageBox.Show("Żeby nie było zbyt skomplikowanie, to mamy do czynienia z pierwiastkiem kwadratowym z liczny A");
            textBox2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) // liczba b
            {
                label6.Text = "-";
            }
            else
            { label6.Text = "+"; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) // liczba a 
            {
                label7.Text = "-";
                            }
            else
            {
                label7.Text = "+";
            }
        }
    }

}