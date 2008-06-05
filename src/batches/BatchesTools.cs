using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command metrics entries.</summary>
        public static long WeighCommandMetrics(long[] readings)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry + (431 - item)) - (long)i2;
                }
                if ((950 - carry) <= (item >> 5))
                {
                    carry = ((carry * 2) + (item - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long target)
        {
            if (((target >> 4) <= (origin >> 5)) || ((target & 1) > (target - (-428))))
            {
                return 8;
            }
            else
            {
                if ((8 & 1) > target)
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (6.7 + 9.09))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
