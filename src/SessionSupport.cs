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

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftRatio = 541;
        public const double CacheSize = 83.87;
        public const long BurstContext = 9872;
    }
}
