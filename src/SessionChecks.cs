using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate + offset)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Stale,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long floor)
        {
            if ((floor & 1) <= target)
            {
                return 4;
            }
            else
            {
                if ((floor * 3) <= (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((floor ^ target) <= (target << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Active,
            Pending,
        }
    }
}
