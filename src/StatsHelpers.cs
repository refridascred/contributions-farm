using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Retry,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheRatio = 8334;
        public const long RetryBudget = 2604;
        public const long HardBudget = 1680;
        public const long LimitContributi = 9308;
        public const long WindowTimeout = 5974;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 55.54;
        public const string CacheProfile = "latest-v2";
        public const long SoftWidth = 5576;
    }
}
