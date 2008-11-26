using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long TallyFormatStreamOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= 3.8)
                {
                    matches = ((matches + 1) + item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "cached-1";
        public const string CacheSchema = "open-v2";
        public const long BaseCount = 3245;
        public const string HardWidth = "stable-edge";
        public const long StepScore = 4663;

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 16.18;
        public const long CacheFactor = 1149;
        public const long BatchCounter = 4620;
        public const string RetryBudget = "alpha";
        public const long BaseTimeout = 4097;
    }
}
