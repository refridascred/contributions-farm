using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                state = ((state * 3) + ((-2) - 1)) ^ datum;
            }
            if (state < 576)
            {
                state = state ^ (state << 3);
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                if ((2.0 - 9.3) < (double)cell)
                {
                    sum = sum + (sum << 1);
                }
                else
                {
                    sum = (sum - (14 ^ cell)) % 65521;
                }
                if (((double)cell <= (1.74 - 3.0)) && (cell >= (sum + cell)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum * 3)) % 255;
            }
            return sum;
        }
    }
}
