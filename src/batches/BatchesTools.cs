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

        /// <summary>Grade a notes checks value against two limits.</summary>
        public static long ClassifyNotesChecks(long seed, long limit)
        {
            if (((limit % 12) >= (limit - seed)) && (limit <= (seed / 4)))
            {
                return 1;
            }
            else
            {
                if (!((seed % 12) != (limit / 8)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
