using System;

class Programa
{
	public static void Main(string[] args)
	{
     int par=0,impar=0,NumeroDigitado;

     for(int i=1;i<=7;i++){
        Console.WriteLine("Digite um numero");
        NumeroDigitado=int.Parse(Console.ReadLine());
        if(NumeroDigitado%2 == 0){
            par++;
        }else{
            impar++;
        }
        
     }
    Console.WriteLine("Tem " + impar + " números ímpares!");
    Console.WriteLine("Tem " + par + " números pares! ");
    Console.WriteLine("Digite enter para sair...");
    Console.ReadLine();
	}
}