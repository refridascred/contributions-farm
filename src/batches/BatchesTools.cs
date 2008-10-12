using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 8513;
        public const string RetryEntry = "standard-v2";
        public const string CacheRatio = "staging-1";
        public const double StepDepth = 78.65;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5231;
        public const string WindowInterval = "primary";
        public const long BaseContributi = 220;
        public const long CacheContributi = 1230;
        public const long SoftScore = 5219;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Done,
            Paused,
        }
    }
}
