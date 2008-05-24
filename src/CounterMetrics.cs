using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
