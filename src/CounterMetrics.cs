using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
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
