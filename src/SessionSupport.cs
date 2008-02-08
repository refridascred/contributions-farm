using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftDepth = 3180;
        public const long MinChecks = 1197;
        public const double HardLevel = 16.49;
        public const string BaseChecks = "stable-1";
        public const string BurstChecks = "strict";

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4246;
        public const string LimitMetric = "local-edge";
        public const string MinDepth = "staging-v2";
    }
}
