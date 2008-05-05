using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8178;
        public const long MinFactor = 7722;
        public const string CacheDepth = "staging";
        public const long BatchInterval = 6631;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 3232;
        public const double DefaultProfile = 79.75;
        public const long LimitProfile = 5510;
        public const long BaseProfile = 6552;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
