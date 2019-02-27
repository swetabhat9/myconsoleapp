using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myapp;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            //Here goes the logic to do some stuff
            
            //here goes the logic for feature 1
            int sum = feature1.add(10,20);
            Console.WriteLine(sum);

            //here goes the logic for feature 2
            int product = feature2.multiply(10, 20);
            Console.WriteLine(sum);
        }
    }
}
