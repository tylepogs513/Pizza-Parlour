using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text, num;
            text = inputText.Text;
           
            double numberOne, numberTwo, numberThree, numberFour, numberFive;
            numberOne = 7.00;
            numberTwo = 1.25;
            numberThree = 1.13;
            numberFour = Convert.ToDouble(inputText.Text);
            numberFive = (numberOne + (numberTwo * numberFour)) * numberThree;
            num = numberFive.ToString(".##");

            totalLabel.Text = "The price of a pizza with " + numberFour + " toppings is $" + num + ".";
        }
    }
}