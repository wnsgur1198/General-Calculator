using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool opPress = false;
        double SaveValue;
        bool dotpress = false;
        char op;

        public Form1()
        {
            InitializeComponent();
            txtInput.Text = 0.ToString();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double res=0;
            if (op == '+')
                res = SaveValue + Double.Parse(txtInput.Text);
            else if(op== '-')
                res = SaveValue - Double.Parse(txtInput.Text);
            else if(op=='*')
                res = SaveValue * Double.Parse(txtInput.Text);
            else if(op=='/')
                res = SaveValue / Double.Parse(txtInput.Text);

            opPress = true;
          
            txtInput.Text = res.ToString();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "1";
            else if (opPress == true)
            {
                txtInput.Text = "1";
                opPress = false;
            }
            else
            txtInput.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "2";
            else if (opPress == true)
            {
                txtInput.Text = "2";
                opPress = false;
            }
            else
            txtInput.Text += "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "7";
            else if (opPress == true)
            {
                txtInput.Text = "7";
                opPress = false;
            }
            else
                txtInput.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "8";
            else if (opPress == true)
            {
                txtInput.Text = "8";
                opPress = false;
            }
            else
                txtInput.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "9";
            else if (opPress == true)
            {
                txtInput.Text = "9";
                opPress = false;
            }
            else
            txtInput.Text += "9";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "4";
            else if (opPress == true)
            {
                txtInput.Text = "4";
                opPress = false;
            }
            else
            txtInput.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "5";
            else if (opPress == true)
            {
                txtInput.Text = "5";
                opPress = false;
            }
            else
            txtInput.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "6";
            else if (opPress == true)
            {
                txtInput.Text = "6";
                opPress = false;
            }
            else
            txtInput.Text += "6";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "3";
            else if(opPress == true)
            {
                txtInput.Text = "3";
                opPress = false;
            }
            else
                txtInput.Text += "3";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
                txtInput.Text = "0";
            else if (opPress == true)
            {
                txtInput.Text = "0";
                opPress = false;
            }
            else
            txtInput.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //더하기
            opPress = true;
            SaveValue = Double.Parse(txtInput.Text);
            op = '+';
            dotpress = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //곱하기
            opPress = true;
            SaveValue = Double.Parse(txtInput.Text);
            op = '*';
            dotpress = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //나누기
            opPress = true;
            SaveValue = Double.Parse(txtInput.Text);
            op = '/';
            dotpress = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //빼기
            opPress = true;
            SaveValue = Double.Parse(txtInput.Text);
            op = '-';
            dotpress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reset
            txtInput.Text = 0.ToString();
            opPress = false;
            dotpress = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dotpress == false)
            {
                txtInput.Text += ".";
                dotpress = true;
            }
           
        }
    }
}
