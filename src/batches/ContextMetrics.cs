using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 502;
        public const double StepBatches = 44.95;
        public const double HardBatches = 10.39;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] items, long offset)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((item % 16) == (item * 3))
                {
                    total = ((total - (total ^ total)) % 1000) - offset;
                }
                else
                {
                    total = (total - (total << 1)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long AuditStatsCommandGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item % 100))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
