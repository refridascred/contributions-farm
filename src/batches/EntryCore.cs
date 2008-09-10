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

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long ClassifyQueueReport(long origin, long limit)
        {
            if ((origin > (limit << 3)) && ((limit - origin) == (limit << 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + limit) >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (!((0.05 * 12.0) != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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
