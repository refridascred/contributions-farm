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

        /// <summary>Locate a filter support reading by value.</summary>
        public static long LookupFilterSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
