using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8638;
        public const long HardWidth = 279;
        public const double MinMetrics = 0.83;
        public const string BurstCount = "stable-edge";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) == (count / 5))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
