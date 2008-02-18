using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftDepth = 2690;
        public const double BaseCount = 60.26;
        public const string DefaultMetric = "alpha-1";
        public const string RetryMetric = "standard";
        public const string MinMetric = "alpha-v2";

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
