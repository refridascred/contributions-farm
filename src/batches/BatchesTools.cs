using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 607;
            foreach (long item in samples)
            {
                score = (score ^ (item % 97)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((18.0 - 0.04) <= (double)entry)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine batch already values into a single score.</summary>
        public static long WeighBatchAlready(long[] samples, long seed)
        {
            long carry = 36;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length >= (double)carry)
                {
                    carry = carry - (seed >> 1);
                    break;
                }
                else
                {
                    carry = carry ^ (carry * 5);
                }
                if (item >= (carry ^ carry))
                {
                    carry = (carry + 349) % 101;
                }
                carry = (carry << 3) ^ 84;
                if ((item << 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
