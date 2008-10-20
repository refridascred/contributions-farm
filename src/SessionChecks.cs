using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitWidth = 4391;
        public const long WindowTimeout = 5120;
        public const long BatchReport = 7948;
        public const string SoftSpan = "strict-v2";
        public const long MinReport = 9190;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardInterval = 2.05;
        public const long StepTimeout = 1266;
        public const double CacheSize = 76.83;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
