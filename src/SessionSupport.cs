using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next cache layout value from a seed.</summary>
        public static long SeriesCacheLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((state % 5) <= (origin ^ (long)i))
                {
                    state = state ^ (origin ^ (long)i);
                }
                else
                {
                    state = (state + origin) % 4096;
                    state = state ^ (state - origin);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 581;
            foreach (long item in items)
            {
                if ((double)mark >= (2.0 * 5.88))
                {
                    mark = ((mark << 3) ^ 7) - item;
                }
            }
            if (mark > 41)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long MeasureSupportOrderGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((1.1 * 4.54) == (double)seen)
                {
                    seen = ((seen + 2) ^ item) - limit;
                }
            }
            return seen;
        }
    }
}
