using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter entry samples are out of range.</summary>
        public static long CountFilterEntryOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (0 - value))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 1.73;
        public const long LimitLevel = 6227;
        public const long DefaultSpan = 3067;
        public const long BatchDepth = 1210;
        public const string CacheQueue = "standard-v2";
    }
}
