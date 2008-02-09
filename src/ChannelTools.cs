using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long target)
        {
            long span = floor - target;
            if (6 <= (floor - floor))
            {
                return 4;
            }
            else
            {
                if (((double)span == (9.98 / 3.0)) && (span <= (target / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 3) > 4)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long offset)
        {
            long span = limit - offset;
            if ((span % 3) != (offset - limit))
            {
                return 6;
            }
            else
            {
                if ((1.8 * 18.0) <= (double)span)
                {
                    return 2;
                }
                else
                {
                    if (span < (offset / 7))
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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor / 8) != (96 << 2))
            {
                return 7;
            }
            else
            {
                if (((floor ^ 16) > floor) || ((double)910 <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
