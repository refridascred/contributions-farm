using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 2486;
        public const string BaseMetric = "alpha-1";
        public const long SoftRatio = 1036;

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "stable";
        public const string LimitOrder = "staging-v2";
        public const string BurstOrder = "cached";
        public const double CacheLevel = 8.23;
        public const long WindowTimeout = 2099;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) >= (limit + seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
