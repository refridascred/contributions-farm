using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 7722;
        public const double BaseMetrics = 26.6;
        public const long WindowMetrics = 8539;
        public const string MinCount = "primary-1";
        public const double CacheRatio = 77.99;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 3649;
        public const double DefaultBudget = 53.7;
        public const string WindowSize = "primary-v2";
        public const string BurstStream = "latest";

        /// <summary>Grade a format graph value against two limits.</summary>
        public static long BucketFormatGraph(long floor, long limit)
        {
            if ((2.0 > (double)limit) || (limit > (735 - limit)))
            {
                return 3;
            }
            else
            {
                if (floor > (limit + 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
