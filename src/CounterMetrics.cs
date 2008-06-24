using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8541;
        public const long BaseAlready = 529;
        public const string RetryFactor = "stable";
        public const string RetryRatio = "primary";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + (-1)) >= (entry - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
