using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laposte
{
    abstract class StringProcess
    {

        public static void escape(ref string sh)
        {
            sh = sh.Replace("é", "e");
            sh = sh.Replace("è", "e");
            sh = sh.Replace("ê", "e");
            sh = sh.Replace("à", "a");
            sh = sh.Replace("ç", "c");
            sh = sh.Replace("ù", "u");
            sh = sh.Replace("?", "");
            sh = sh.Replace("!", "");
            sh = sh.Replace(".", "");
            sh = sh.Replace(",", "");
            sh = sh.Replace(":", "");
            sh = sh.Replace(";", "");
            sh = sh.Replace("@", "");
            sh = sh.Replace("#", "");
            sh = sh.Replace("(", "");
            sh = sh.Replace(")", "");
            sh = sh.Replace("'", "");
            sh = sh.Replace(" ", "");
            sh = sh.Replace("-", "");
            sh = sh.Replace("_", "");
        }

        public static char[] sortLetterInOrder(ref string arrayToSort)
        {
            char[] tonTableaudeChar = arrayToSort.ToCharArray();
            int i, taille;
            taille = arrayToSort.Length;
            char tmp;
            int firstValue = 0;
            int secondValue = 0;
            while (taille > 0)
            {
                for (i = 0; i < taille - 1; i++)
                {
                    firstValue = Convert.ToInt32(tonTableaudeChar[i]);
                    secondValue = Convert.ToInt32(tonTableaudeChar[i + 1]);
                    if (firstValue > secondValue)
                    {
                        tmp = tonTableaudeChar[i];
                        tonTableaudeChar[i] = tonTableaudeChar[i + 1];
                        tonTableaudeChar[i + 1] = tmp;
                    }
                }
                taille = taille - 1;
            }
            return tonTableaudeChar;
        }
    }
}
