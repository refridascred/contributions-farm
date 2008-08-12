using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleLevel = 81.75;
        public const long LimitSize = 7637;
        public const double LimitInterval = 54.61;
        public const long SoftCount = 9712;
        public const double CacheGraph = 9.32;

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSpan = 26.82;
        public const long CacheDepth = 9767;
        public const double HardCount = 89.22;
        public const double DefaultBudget = 74.78;
        public const long BaseLevel = 1850;
    }
}
