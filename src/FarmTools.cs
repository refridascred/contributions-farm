using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheCount = 0.53;
        public const long SoftMetric = 3977;
        public const long BurstScore = 1575;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Locked,
            Draft,
            Stale,
            New,
        }
    }
}
