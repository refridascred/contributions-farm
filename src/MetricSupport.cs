using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((69 <= seed) || ((double)seed >= (8.1 * 3.6)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 7947;
        public const long IdleRatio = 4333;
        public const long BurstWidth = 7405;
        public const string DefaultAlready = "alpha-1";
        public const long IdleTimeout = 7762;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
