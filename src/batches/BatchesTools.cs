using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 25.45;
        public const long CacheFilter = 2966;
        public const long WindowFilter = 1180;
        public const string CacheSize = "fallback";
        public const string BurstScore = "local-v2";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitRatio = "latest-1";
        public const double IdleDepth = 94.24;
        public const double BaseSchema = 84.9;
    }
}
