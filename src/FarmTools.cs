using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 2611;
        public const long BaseDepth = 4364;
        public const long MaxMetric = 9603;
        public const double HardMetric = 40.9;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheDepth = "latest-v2";
        public const string LimitScore = "strict-edge";
        public const long BurstAlready = 183;
    }
}
