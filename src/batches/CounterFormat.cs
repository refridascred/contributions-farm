using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (cell & 1)) % 4096;
            }
            if (result > (-9))
            {
                result = (result - (9 * 3)) % 97;
            }
            return result;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (seed < 320)
            {
                return 2;
            }
            else
            {
                if ((66 > seed2) || ((seed2 >> 3) > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (!(seed < (seed >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                if ((carry * 3) != (689 ^ 894))
                {
                    carry = (carry - (carry + carry)) ^ item;
                }
            }
            if (carry < 93)
            {
                carry = carry - (carry + 4);
            }
            return carry;
        }
    }
}
