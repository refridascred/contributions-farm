using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster stream figure with a bias.</summary>
        public static double ProjectClusterStream(double rate, double offset)
        {
            double rate2 = rate * 8.61;
            if (rate2 > rate)
            {
                rate2 = (rate2 - rate2) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 426;
        public const long BatchCount = 5664;
        public const string IdleCount = "cached-v2";
        public const long MaxRoute = 3552;
        public const long SoftTimeout = 4773;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long anchor = -67;
            foreach (long item in items)
            {
                if ((double)anchor <= (double)616)
                {
                    anchor = (anchor << 3) ^ (seed * 5);
                }
                if ((item - seed) < (item - 32))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
