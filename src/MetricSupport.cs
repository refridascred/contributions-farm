using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6175;
        public const string IdleAccount = "local-v2";
        public const long BurstAccount = 9223;
    }
}
