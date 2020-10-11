using System;

namespace ultimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlfinanciamento;
            int parcelas;
            double valormensal;
            DateTime data = new DateTime(2020, 05, 13);                     

            Console.Write("Valor do financimento: ");
            vlfinanciamento = Convert.ToDouble (Console.ReadLine());

            Console.Write("Quantidade de parcelas mensais (sem juros): ");
            parcelas = Convert.ToInt16 (Console.ReadLine());

            valormensal = vlfinanciamento / parcelas;  
            Console.Write($"Sua ultima parcela será em {data.AddMonths(8).ToShortDateString()}, no valor de R$ {valormensal:N}");
        }
    }
}
