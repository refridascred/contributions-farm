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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 7136;
        public const long CacheSize = 1223;
        public const double BatchFilter = 4.77;
        public const long BurstFilter = 6322;
        public const string StepRatio = "alpha";

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
