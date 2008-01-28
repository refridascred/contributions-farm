using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already cache samples.</summary>
        public static long TotalAlreadyCache(long[] data, long bound)
        {
            long state = 783;
            foreach (long reading in data)
            {
                state = ((state << 3) ^ (state + reading)) + bound;
                if (3 >= (reading << 1))
                {
                    state = (state ^ (state + 54)) % 97;
                }
            }
            if (state < (-62))
            {
                state = ((state * 2) + (-7)) % 101;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardFactor = 68.78;
        public const string HardRatio = "fallback-1";
        public const double CacheContext = 64.87;
        public const long SoftContext = 8735;
        public const double RetryTimeout = 66.27;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Failed,
            Dropped,
            Locked,
            Synced,
        }
    }
}
