using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Retry,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series, long bound)
        {
            long state = 90;
            foreach (long cell in series)
            {
                state = ((state * 5) + cell) + bound;
            }
            if (state < 703)
            {
                state = (state ^ (state >> 3)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5259;
        public const long BatchLevel = 5978;
        public const double RetryAccount = 63.55;
        public const long SoftScore = 6616;
        public const double BaseLevel = 61.03;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((2 * 4) <= hits)
                {
                    hits = ((hits + 3) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
