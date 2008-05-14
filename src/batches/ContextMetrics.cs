using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 8516;
        public const double BaseWidth = 2.29;
        public const long CacheBatch = 6267;
        public const double CacheLevel = 63.67;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long target)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if ((item << 2) > item)
                {
                    sum = ((sum << 2) ^ (target + target)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "stable-v2";
        public const long BaseFormat = 5661;
        public const long MinFormat = 2584;
        public const string RetryFormat = "stable";
    }
}
