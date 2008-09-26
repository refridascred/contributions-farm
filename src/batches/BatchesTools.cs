using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "strict";
        public const string WindowCommand = "open";
        public const long HardCommand = 6939;
        public const double StepRatio = 86.79;
        public const long BaseCommand = 6823;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 854;
        public const long IdleBudget = 954;
        public const long CacheLevel = 4976;
        public const long BatchStats = 3311;
        public const string RetryStats = "cached-v2";
    }
}
