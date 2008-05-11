using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchTimeout = 3121;
        public const long StepScore = 3268;
        public const long BurstInterval = 4584;
        public const double LimitDepth = 13.6;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 9157;
        public const long WindowRecord = 252;
        public const long LimitSpan = 4711;
        public const long WindowInterval = 8257;
    }
}
