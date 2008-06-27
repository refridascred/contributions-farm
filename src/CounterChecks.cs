using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Paused,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mark = 82;
            foreach (long datum in levels)
            {
                mark = (((mark << 3) ^ mark) % 97) ^ datum;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (5 <= (item / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSize = 8453;
        public const double BatchDepth = 31.07;
        public const long RetryCommand = 4446;
    }
}
