using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 3150;
        public const long MaxDepth = 595;
        public const long CacheRatio = 7626;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
