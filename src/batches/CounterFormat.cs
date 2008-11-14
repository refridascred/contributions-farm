using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Draft,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Rank window session input into a small class.</summary>
        public static long BucketWindowSession(long offset, long floor)
        {
            long delta = offset - floor;
            if (((0.35 / 3.0) == (double)floor) && ((0.2 / 4.0) < (double)offset))
            {
                return 2;
            }
            else
            {
                if ((delta % 8) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (7.4 * 8.6)) && ((offset + 59) > 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            if (((95 / 3) != (bound ^ 47)) || ((seed + (-78)) <= seed))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) < (seed - 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) > (seed << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ bound) != (961 & 15)) && ((272 + bound) <= (bound / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
