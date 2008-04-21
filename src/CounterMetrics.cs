using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 53.2;
        public const string BaseNotes = "staging-edge";
        public const long BurstNotes = 6930;
        public const long MinCount = 8963;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long origin)
        {
            long offset = floor - origin;
            if (offset < (53 / 7))
            {
                return 6;
            }
            else
            {
                if (((double)origin == (7.4 + 6.11)) || ((offset & 15) > (origin ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if (origin > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (5.29 + 4.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((origin << 3) >= origin)
            {
                return 0;
            }
            else
            {
                if ((origin * 3) <= (origin - target))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= (origin * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 3) < 75)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
