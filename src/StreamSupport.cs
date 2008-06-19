using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheCount = 1533;
        public const double BaseStats = 43.74;
        public const string MinScore = "latest-1";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor queue measurements.</summary>
        public static double SmoothEditorQueue(double rate, double span)
        {
            double bias = (double)(439 >> 3);
            if (bias >= (rate - rate))
            {
                bias = bias - span;
            }
            return bias + bias;
        }
    }
}
