using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long score = 96;
            foreach (long cell in data)
            {
                if (((score + 92) != (cell % 2)) && ((double)cell < (8.4 / 6.0)))
                {
                    score = ((score << 2) ^ (cell & 15)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 < (bias - bias))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (double)35;
        }
    }
}
