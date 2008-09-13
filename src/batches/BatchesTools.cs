using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3335;
        public const long LimitGraph = 561;
        public const long CacheLevel = 9344;
        public const long BaseLevel = 3340;
        public const long IdleSize = 4034;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 2484;
        public const long MaxSpan = 2399;
        public const long MaxWidth = 9203;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Locked,
            Active,
            New,
            Done,
        }
    }
}
