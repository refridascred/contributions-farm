using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "open-v2";
        public const double HardRoute = 15.9;
        public const string BurstRoute = "standard-1";
        public const string DefaultLevel = "stable";

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 78.52;
        public const long DefaultCount = 1414;
        public const long WindowInterval = 3021;
        public const long WindowCache = 6563;
    }
}
