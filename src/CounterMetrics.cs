using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!!((9.33 / 8.0) < (double)seed))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
