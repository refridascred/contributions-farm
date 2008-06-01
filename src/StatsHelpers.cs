using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultTimeout = "primary-1";
        public const long BurstAccount = 5887;
        public const string DefaultSpan = "primary";
        public const long LimitScore = 9084;
        public const long CacheScore = 4959;

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long bound)
        {
            long prev = limit - bound;
            if (((bound + prev) <= (bound ^ bound)) || ((limit ^ bound) <= prev))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) > (8 + prev))
                {
                    return 2;
                }
                else
                {
                    if ((69 / 9) >= (0 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3120;
        public const long BatchRatio = 3484;
        public const string RetrySchema = "cached-1";
        public const double MinScore = 68.57;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long origin2)
        {
            if ((0.4 * 4.25) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin2) >= (origin - 685))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 3) == ((-3) + origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Locked,
            Pending,
        }
    }
}
