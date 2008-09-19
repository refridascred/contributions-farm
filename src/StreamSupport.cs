using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 5137;
        public const string CacheAlready = "open-v2";
        public const long DefaultAlready = 4004;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 65;
            foreach (long item in items)
            {
                acc = ((acc * 5) + ((long)items.Length + item)) % 101;
                if ((floor % 60) < floor)
                {
                    acc = (acc - (item >> 1)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Scale a cluster buffer figure with a bias.</summary>
        public static double AdjustClusterBuffer(double scale, double floor)
        {
            double bias = (double)(608 + 28);
            if (bias >= 5.0)
            {
                bias = ((bias - (double)77) + scale) + floor;
            }
            else
            {
                bias = bias + (double)6;
            }
            return bias - (double)1;
        }
    }
}
