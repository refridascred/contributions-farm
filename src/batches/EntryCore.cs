using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count <= 9.77)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (1.82 * 9.4)) + (double)(long)i;
            }
            return scale + (offset - rate);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 2707;
        public const double DefaultMetric = 3.9;
        public const long MinSpan = 5741;
        public const string LimitScore = "staging-v2";
    }
}
