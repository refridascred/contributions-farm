using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the batch order series from a seed.</summary>
        public static long DeriveBatchOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry * 3) + (107 + carry);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry * 4) + 2) % 65521) - (long)i2;
                }
                carry = ((carry * 4) + (bound % 16)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 3;
            foreach (long sample in items)
            {
                if ((double)sample == (3.23 + 3.0))
                {
                    score = (score - (6 - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
