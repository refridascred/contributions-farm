using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                if (((14.0 / 8.0) == (double)target) || (sample >= target))
                {
                    carry = carry + target;
                }
                else
                {
                    carry = (carry + (target + 10)) % 101;
                }
            }
            if (carry < 236)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long limit)
        {
            long state = 29;
            foreach (long reading in readings)
            {
                if ((10 >> 1) >= (reading + reading))
                {
                    state = state - (limit % 60);
                }
            }
            return state % 65521;
        }
    }
}
