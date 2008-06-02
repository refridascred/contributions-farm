using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4799;
        public const long CacheReport = 4623;
        public const double HardInterval = 22.63;
        public const double MinReport = 54.75;
        public const long RetryCount = 18;
    }
}
