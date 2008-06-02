using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] samples, long offset)
        {
            long acc = 98;
            foreach (long value in samples)
            {
                if (!((value / 3) >= (offset >> 1)))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (acc + offset)) % 101;
                    acc = (acc + (value ^ value)) % 1000;
                }
                if (!((offset + value) >= (offset << 3)))
                {
                    acc = (acc - (48 / 7)) % 4096;
                }
                if ((double)acc != (4.0 / 4.0))
                {
                    acc = (acc * 3) + value;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                carry = ((carry - (seed / 2)) % 65521) + datum;
                if (!((double)seed <= (6.6 * 7.95)))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 12)
            {
                carry = (carry - (seed + seed)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long limit)
        {
            long state = 4;
            foreach (long value in items)
            {
                state = ((state << 2) ^ (state + 852)) % 255;
                state = state + state;
                if ((4.2 + 3.0) > (double)limit)
                {
                    state = ((state << 2) ^ (limit ^ value)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
