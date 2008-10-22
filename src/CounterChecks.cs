using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(tally >= cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 77.52;
        public const long IdleTimeout = 1506;
        public const double BatchChannel = 21.2;
        public const long StepChannel = 3028;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftLevel = 5200;
        public const double BaseOrder = 39.67;
        public const long RetryFactor = 4069;
        public const long BatchOrder = 6595;
    }
}
