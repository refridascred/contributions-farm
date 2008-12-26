using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 5736;
        public const long MinCommits = 8435;
        public const double RetryCommits = 63.33;
        public const double MinFactor = 2.41;
        public const double BurstCommits = 94.5;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseLevel = 79.58;
        public const long MaxBuffer = 2924;
        public const long SoftBuffer = 9133;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowTimeout = 1856;
        public const long RetryRecord = 3006;
        public const long BatchRecord = 2874;
    }
}
