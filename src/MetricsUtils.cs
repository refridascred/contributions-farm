using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((4 <= (step - step)) || ((target / 3) <= target))
            {
                return 4;
            }
            else
            {
                if (((double)target == (8.5 * 6.06)) && ((step / 2) <= step))
                {
                    return 2;
                }
                else
                {
                    if (227 >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + step) <= ((-72) << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
