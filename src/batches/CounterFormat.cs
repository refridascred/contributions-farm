using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)bound != (13.0 - 8.5))
            {
                return 5;
            }
            else
            {
                if ((seed <= (seed + diff)) || ((284 + diff) < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((diff + bound) < (seed & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long origin)
        {
            long state = -9;
            foreach (long cell in values)
            {
                if ((origin << 2) >= (state & 255))
                {
                    state = ((state ^ (306 / 8)) % 1000) + cell;
                }
                if ((double)origin < (3.0 - 7.24))
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = ((state << 2) ^ (state + 816)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((3.2 / 4.0) < (double)origin)
                {
                    mark = (mark << 2) ^ (mark - mark);
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
