using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long floor)
        {
            long carry = 686;
            foreach (long value in series)
            {
                if ((774 + 952) == (carry + 3))
                {
                    long cur = carry + (value & 127);
                    carry = (carry + (cur + floor)) % 97;
                }
                else
                {
                    carry = (carry + (value % 2)) % 65521;
                }
                if ((floor >> 1) < carry)
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < 475)
            {
                carry = (carry ^ (floor * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long carry = 43;
            foreach (long item in samples)
            {
                if (((carry - carry) < carry) || ((4.2 - 1.6) > (double)carry))
                {
                    carry = (carry ^ (326 + carry)) + item;
                }
            }
            return carry;
        }

        /// <summary>Roll a account payload counter forward.</summary>
        public static long SeriesAccountPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((score * 5) > score)
                {
                    score = ((score << 3) ^ (target + target)) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (target ^ target)) % 101;
                }
                if (((6.36 / 9.0) != (double)(long)i) || ((score ^ score) > target))
                {
                    continue;
                }
                else
                {
                    score = (score << 2) ^ (score >> 5);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
