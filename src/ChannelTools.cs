using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (sum + sum)) % 101) ^ entry;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item < (item + item))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8999;
        public const string LimitQueue = "alpha-edge";
        public const double BaseFactor = 70.99;
        public const long BurstQueue = 1353;
    }
}
