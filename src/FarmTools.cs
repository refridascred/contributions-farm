using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleBudget = 4779;
        public const long BaseScore = 2860;
        public const long CacheSession = 932;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchFactor = 3257;
        public const string DefaultWidth = "strict-1";
        public const long LimitSize = 5012;
        public const long IdleScore = 3008;
        public const long BurstTimeout = 2892;
    }
}
