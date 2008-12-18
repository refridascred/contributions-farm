using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftTimeout = "fallback-v2";
        public const string CacheReport = "open-edge";
        public const double MaxReport = 59.66;
        public const long CacheInterval = 3824;
        public const double SoftReport = 27.75;
    }
}
