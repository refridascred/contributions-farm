using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long mark = -35;
            foreach (long datum in items)
            {
                if (((double)85 != (double)mark) || ((long)items.Length > (867 << 1)))
                {
                    mark = (mark ^ mark) + datum;
                }
                if ((mark - seed) > (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 61)
            {
                mark = (mark - (seed ^ (long)items.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Idle,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long floor)
        {
            if ((double)origin > 4.0)
            {
                return 5;
            }
            else
            {
                if ((floor - floor) > origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin <= (double)floor) && ((origin & 31) == (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
