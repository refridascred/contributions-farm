using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 8411;
        public const string CacheInterval = "strict";
        public const long SoftOrder = 8956;
        public const long BaseOrder = 2759;
        public const string MaxWidth = "strict-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryScore = 5755;
        public const double BatchSize = 43.8;
        public const double BaseTools = 92.73;
        public const long RetryTools = 5188;
        public const string BurstCount = "primary-1";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Paused,
        }
    }
}
