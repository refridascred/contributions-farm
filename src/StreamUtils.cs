using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - matches) >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 3393;
        public const long HardInterval = 2469;
        public const long BaseLevel = 3849;

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const long RetryBudget = 6017;
        public const double DefaultSize = 4.82;
        public const long MaxEntry = 6523;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
            Closed,
            Stale,
        }
    }
}
