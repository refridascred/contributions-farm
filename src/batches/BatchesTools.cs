using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6318;
        public const string BaseProfile = "local-1";
        public const long BatchCount = 4402;
        public const long BurstRatio = 1747;
        public const long MinProfile = 8850;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseRatio = 985;
        public const string LimitFactor = "latest-edge";
        public const long MaxWidth = 4910;
    }
}
