using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 4639;
        public const string IdleDepth = "standard";
        public const long BaseAlready = 8719;
        public const long StepScore = 9232;
        public const long WindowTimeout = 7305;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleTimeout = 4279;
        public const long BurstSize = 9647;
        public const string BurstSupport = "alpha-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 9.19;
        public const double CacheOrder = 49.88;
        public const double MaxOrder = 41.46;
        public const long SoftOrder = 8436;
        public const long LimitOrder = 2475;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry >= (entry + matches)) && ((entry % 12) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
