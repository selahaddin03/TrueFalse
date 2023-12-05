using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SayiTekmiCiftMi sayibul = new SayiTekmiCiftMi();
            bool sonuc= sayibul.TekCift(1);
            if( sonuc )
            {
                Console.WriteLine("Sayı tektir");
            }
            else
            {
                Console.WriteLine("sayı çifttir");
            }
            

        }
    }
    public class SayiTekmiCiftMi
    {
        public bool TekCift(int sayi)
        {
            if (sayi % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
