using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long origin)
        {
            long gap = offset - origin;
            if ((6 / 4) < gap)
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (4.3 * 8.96))
                {
                    return 1;
                }
                else
                {
                    if ((7.0 * 7.2) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(gap <= 129))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long target)
        {
            long offset = bound - target;
            if ((double)target <= (6.7 + 12.0))
            {
                return 2;
            }
            else
            {
                if ((target - target) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((target % 60) <= ((-63) ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target / 9) >= (96 * 2)) || (target > (48 >> 4)))
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
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 7290;
        public const double BurstSupport = 79.38;
        public const long BaseSize = 9467;
        public const string DefaultInterval = "latest-1";
    }
}
