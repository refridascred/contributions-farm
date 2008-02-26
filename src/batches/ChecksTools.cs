using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long limit)
        {
            long lane = floor - limit;
            if ((double)limit <= (0.5 * 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (9.49 - 19.0))
                {
                    return 5;
                }
                else
                {
                    if (73 <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long target)
        {
            long cur = seed ^ target;
            if (!((seed ^ cur) >= (seed % 60)))
            {
                return 4;
            }
            else
            {
                if ((5.8 < (double)cur) || ((double)seed >= (6.51 / 4.0)))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) < (cur - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Active,
        }
    }
}
