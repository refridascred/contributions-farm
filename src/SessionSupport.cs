using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 90.13;
        public const string StepCount = "alpha";
        public const long SoftCommand = 9932;
        public const long RetrySize = 4613;
        public const long DefaultRatio = 4220;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            New,
            Idle,
            Queued,
        }
    }
}
