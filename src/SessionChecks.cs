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

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSize = 9738;
        public const long CacheMetric = 4844;
        public const double StepBudget = 49.37;
        public const double RetryMetric = 60.83;
        public const long WindowMetric = 843;
    }
}
