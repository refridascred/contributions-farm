using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long BucketReportSupport(long offset, long origin)
        {
            long step = offset ^ origin;
            if ((offset % 97) == (origin + step))
            {
                return 6;
            }
            else
            {
                if ((3 - origin) <= 616)
                {
                    return 1;
                }
                else
                {
                    if ((8.9 + 2.8) < (17.0 - 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((602 ^ origin) <= (offset << 1))
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
