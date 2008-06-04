using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long CombineCacheSession(long[] items)
        {
            long carry = 371;
            foreach (long sample in items)
            {
                long cur = carry;
                if (carry > (cur + sample))
                {
                    cur = ((cur << 2) ^ carry) % 97;
                    cur = (cur + (3 << 2)) % 255;
                }
                if ((carry >> 1) >= (sample & 127))
                {
                    carry = ((carry << 3) ^ (carry & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long limit)
        {
            long mark = 24;
            foreach (long value in items)
            {
                if (((double)value >= (5.74 + 3.0)) && ((limit + limit) == (mark - value)))
                {
                    mark = mark + (limit + limit);
                }
            }
            if (mark > 32)
            {
                mark = mark - 7;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if (895 > (limit + state))
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = (state + limit) % 255;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
