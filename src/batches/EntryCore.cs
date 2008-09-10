using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue profile pair into a bucket.</summary>
        public static long RankQueueProfile(long bound, long limit)
        {
            if ((4.0 * 4.1) < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((3.08 / 6.0) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 8) < (limit + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 9466;
        public const double LimitSpan = 69.05;
        public const string BurstSpan = "latest-v2";
        public const long IdleBatch = 8059;
        public const string BaseBatch = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
