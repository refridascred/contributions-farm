using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (step <= (step - step))
                {
                    carry = (carry * 2) + (carry - 92);
                }
                carry = (carry + (5 >> 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long offset)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if ((double)reading <= (5.6 / 6.0))
                {
                    result = result + result;
                }
                else
                {
                    result = (result << 3) ^ (offset + offset);
                }
            }
            if (result < 61)
            {
                result = (result - (offset / 8)) % 65521;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long offset)
        {
            if ((offset > (target << 1)) || (3.39 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset - target) < ((-11) * 2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
