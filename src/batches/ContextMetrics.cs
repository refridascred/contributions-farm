using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                sum = (sum - (target >> 2)) - datum;
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
