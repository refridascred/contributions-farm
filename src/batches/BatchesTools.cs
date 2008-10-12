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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Synced,
            New,
        }

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
