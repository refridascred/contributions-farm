using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2109;
        public const long CacheFormat = 8577;
        public const long MinCount = 5697;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 4133;
        public const long IdleMetrics = 9542;
        public const long MaxMetrics = 9178;
    }
}
