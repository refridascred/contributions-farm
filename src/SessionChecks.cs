using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 1497;
        public const long CacheMetric = 2974;
        public const long BurstSpan = 4476;

        /// <summary>Check that every payload githubfarm entry stays within the limit.</summary>
        public static bool CheckPayloadGithubfarmRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long target)
        {
            if ((seed << 3) > (seed - seed))
            {
                return 4;
            }
            else
            {
                if (((13.0 - 6.4) != (double)seed) || (2.36 <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed + target) != (seed % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target >> 2) <= (target & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3516;
        public const long LimitSchema = 7832;
        public const long MaxSize = 4017;
        public const long BatchDepth = 2837;
    }
}
