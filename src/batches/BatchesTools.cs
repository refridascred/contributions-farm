using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5249;
        public const long BaseSpan = 8270;
        public const string CacheScore = "staging-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 39.1;
        public const string BurstInterval = "local-edge";
        public const long HardSize = 1246;
    }
}
