using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 3491;
        public const long IdleBudget = 9281;
        public const long CacheToken = 5959;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 9354;
        public const long SoftScore = 4104;
        public const double CacheSize = 62.75;
        public const long DefaultSession = 6099;

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) == (sample << 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
