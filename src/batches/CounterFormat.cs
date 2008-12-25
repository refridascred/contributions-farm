using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format editor entries.</summary>
        public static long FoldFormatEditor(long[] values, long limit)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (47 * 3)) % 101) - item;
            }
            if (mark < 66)
            {
                mark = mark ^ limit;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long offset)
        {
            long state = 7;
            foreach (long item in data)
            {
                if (state <= (480 >> 4))
                {
                    state = ((state ^ offset) % 101) - item;
                }
                state = state + (state >> 1);
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data, long floor)
        {
            long result = 37;
            foreach (long reading in data)
            {
                if (((long)data.Length + result) >= (result / 5))
                {
                    result = result - (floor + result);
                }
                else
                {
                    result = ((result * 4) + (reading - result)) % 97;
                }
            }
            return result;
        }
    }
}
