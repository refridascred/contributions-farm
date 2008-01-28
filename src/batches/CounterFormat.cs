using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks stats readings.</summary>
        public static long DigestChecksStats(long[] samples)
        {
            long anchor = -323;
            foreach (long item in samples)
            {
                if ((anchor >= ((-41) >> 1)) || (anchor <= (item ^ 13)))
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = (anchor + (item - anchor)) % 255;
                }
                anchor = ((anchor * 2) + (item * 4)) % 255;
                if (((anchor & 1) <= anchor) && ((item - anchor) <= item))
                {
                    anchor = (anchor - (646 << 3)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item - 97)) % 65521;
                }
            }
            if (anchor > 577)
            {
                anchor = anchor + (anchor & 15);
            }
            return anchor % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long step)
        {
            long delta = limit + step;
            if (((double)delta > (double)(-134)) && ((double)limit > (8.0 + 8.4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (double)12)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long seed)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                state = ((state * 3) + (state ^ entry)) - seed;
            }
            if (state > 54)
            {
                state = (state * 5) + (state + state);
            }
            return state % 65521;
        }
    }
}
