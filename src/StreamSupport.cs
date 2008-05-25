using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route tools reading by value.</summary>
        public static long FindRouteToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long limit)
        {
            if ((offset < ((-9) >> 3)) || ((727 + 1) >= ((-66) + offset)))
            {
                return 2;
            }
            else
            {
                if (limit < 5)
                {
                    return 0;
                }
                else
                {
                    if ((21 >> 4) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (29 <= ((-450) ^ (long)items.Length))
                {
                    hits = ((hits + 1) ^ cell) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
