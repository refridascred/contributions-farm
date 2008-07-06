using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((1.5 + 14.0) > (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((121 ^ hits) > (1 & 127))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
