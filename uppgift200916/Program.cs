using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift200916
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public String Price { get; set; }   //sträng krashar inte och omvandlar även den till en string när vi skriver ut
        public String Info()
        {
            return ($"{Make} {Model}");
        }
        public String AllInfo()
        {
            return ($"A {Color} {Make} {Model} Costing: {Price} SEK");
        }
    }
}
