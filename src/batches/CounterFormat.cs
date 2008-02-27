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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry > (18.0 * 7.37)) && ((entry << 2) == (27 * 3)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
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
