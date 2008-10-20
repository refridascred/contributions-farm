using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitLevel = 4159;
        public const string RetryCluster = "strict-v2";
        public const string RetryFactor = "open-v2";
        public const long IdleLevel = 3623;
        public const long WindowTimeout = 5002;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            New,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
