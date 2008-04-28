using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            long lane = step - limit;
            if ((lane - 9) < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((235 + step) == (8 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((lane * 5) >= 86)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step <= (17.0 + 3.9)) || ((2.64 - 4.0) != (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowWidth = 9.86;
        public const long LimitDepth = 1401;
        public const string CacheTimeout = "local-edge";
        public const string RetryCount = "latest-edge";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
