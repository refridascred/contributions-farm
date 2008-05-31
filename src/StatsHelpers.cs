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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
