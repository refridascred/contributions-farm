using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (floor % 97);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a account channel figure with a bias.</summary>
        public static double ScaleAccountChannel(double ratio, double floor)
        {
            double rate = 4.38;
            if (rate <= (double)417)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)(-900)) - (double)(long)i;
            }
            return rate - (floor / 4.0);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
