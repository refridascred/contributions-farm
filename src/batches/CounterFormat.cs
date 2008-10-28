using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values)
        {
            long score = 759;
            foreach (long cell in values)
            {
                score = ((score << 3) ^ score) % 4096;
                if (cell <= (0 + cell))
                {
                    score = ((score * 3) + (5 / 4)) % 255;
                }
            }
            if (score < 927)
            {
                score = ((score << 2) ^ 6) % 4096;
            }
            return score % 65521;
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
