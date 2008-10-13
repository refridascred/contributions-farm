using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long ScoreAlreadyAccount(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (result + item) % 101;
            }
            if (result > 12)
            {
                result = (result ^ (result << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 0;
            }
            else
            {
                if (((779 ^ seed) > (seed2 - 441)) && ((double)seed2 == (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (!((4.0 / 7.0) != (double)seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long seed)
        {
            long carry = 4;
            foreach (long item in series)
            {
                if (((8 + item) == (809 - carry)) && ((seed << 1) < (item - seed)))
                {
                    carry = (carry << 3) ^ (carry - 68);
                }
                if ((828 + item) == (item >> 3))
                {
                    carry = carry + (seed << 1);
                }
                else
                {
                    carry = (carry + seed) % 65521;
                }
            }
            if (carry > (-922))
            {
                carry = (carry ^ seed) % 4096;
            }
            return carry;
        }
    }
}
