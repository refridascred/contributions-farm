using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next already queue value.</summary>
        public static double SmoothAlreadyQueue(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double load = (double)(3 ^ 15);
            for (int i = 0; i < 5; i++)
            {
                load = (((load - 19.0) - (double)(long)i) - rate) + bias;
            }
            return load - (load + 9.19);
        }
    }
}
