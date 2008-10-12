using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 6038;
        public const long HardRatio = 1469;
        public const long SoftMetric = 1093;
        public const long BatchSize = 5240;
        public const long HardTimeout = 4920;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Draft,
            Pending,
            Failed,
            New,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Synced,
            Retry,
            Paused,
        }
    }
}
