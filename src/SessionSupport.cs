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

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "open";
        public const string WindowDepth = "local-1";
        public const string MinProfile = "standard-v2";
        public const long WindowLevel = 5777;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "latest-edge";
        public const string RetryStream = "strict-v2";
        public const double MinStream = 63.3;
        public const long BurstTimeout = 8725;
    }
}
