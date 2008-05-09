using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((4.17 / 9.0) != (double)hits) && ((reading * 2) >= (hits % 97)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 5277;
        public const long MaxToken = 8121;
        public const long SoftToken = 5397;
        public const double SoftLevel = 89.3;
        public const long LimitToken = 5936;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSize = 92.48;
        public const long MinToken = 8923;
        public const long BurstCount = 265;
        public const long DefaultToken = 6455;
    }
}
