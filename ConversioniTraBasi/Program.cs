using System;

namespace ConversioniTraBasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, numero, valorebase;
            string valore_convertito = "";
            Console.WriteLine("inserisci la base in cui vuoi convertire");
            valorebase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il numero da convertire");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                resto = numero % valorebase;
                if (resto == 15)
                {

                    valore_convertito = "f" + valore_convertito;
                }
                if (resto == 14)
                {
                    resto = numero % valorebase;
                    if (resto == 13)
                    {

                        valore_convertito = "f" + valore_convertito;
                        if (resto == 12)
                        {

                            valore_convertito = "f" + valore_convertito;
                        }
                        valore_convertito = "f" + valore_convertito;
                    }
                    if (resto == 11)
                    {

                        valore_convertito = "f" + valore_convertito;
                    }
                    if (resto == 10)
                    {

                        valore_convertito = "f" + valore_convertito;
                    }
                    numero = numero / valorebase;
                    valore_convertito = Convert.ToString(resto) + valore_convertito;
                }
                Console.WriteLine($"il numero binario é {valore_convertito}");
                Console.ReadLine();
            }
        }
    }
}