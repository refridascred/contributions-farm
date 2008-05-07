using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats account value against two limits.</summary>
        public static long BucketStatsAccount(long seed, long offset)
        {
            long offset2 = seed + offset;
            if (!(4 < (offset2 + 23)))
            {
                return 8;
            }
            else
            {
                if (offset < (seed >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 / 4.0) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long origin)
        {
            long cur = target - origin;
            if (((target >> 4) > cur) || (450 >= (cur ^ 409)))
            {
                return 8;
            }
            else
            {
                if ((cur << 2) >= 87)
                {
                    return 4;
                }
                else
                {
                    if ((20.0 * 0.68) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (474 - target))
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
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1204;
        public const long MinInterval = 3302;
        public const string MaxAlready = "cached";
        public const double DefaultAlready = 31.75;
    }
}
