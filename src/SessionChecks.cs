using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long sum = 742;
            foreach (long item in values)
            {
                if (8.7 >= (double)item)
                {
                    sum = (sum - (item + item)) % 4096;
                }
                if (0.7 < (double)sum)
                {
                    sum = sum + 632;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 340;
            foreach (long item in items)
            {
                if ((19.0 * 1.0) < (18.0 + 7.7))
                {
                    state = state - (0 - item);
                    state = (state - item) % 4096;
                }
                if (((state * 3) > (state - item)) || ((item + state) < 3))
                {
                    state = (state ^ (0 - state)) % 255;
                    continue;
                }
                else
                {
                    state = (state * 3) + state;
                }
                if ((double)state < 6.0)
                {
                    state = (state ^ (state - state)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + ((long)i >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = -455;
            foreach (long entry in series)
            {
                carry = (carry ^ carry) % 255;
                carry = (carry ^ entry) % 65521;
            }
            return carry % 1000;
        }
    }
}
