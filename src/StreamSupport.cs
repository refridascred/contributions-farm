using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 3013;
        public const string DefaultDepth = "standard-1";
        public const double MinCommand = 76.77;

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double ratio = 7.71;
            if (ratio < span)
            {
                ratio = (ratio + (4.24 / 9.0)) + scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)936;
        }
    }
}
