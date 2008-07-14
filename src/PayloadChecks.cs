using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Retry,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 8168;
        public const long MinCommand = 823;
        public const long IdleTimeout = 3540;
        public const long IdleCommand = 2487;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally + 858))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
