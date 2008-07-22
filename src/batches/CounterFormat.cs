using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 1) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long carry = -75;
            foreach (long reading in samples)
            {
                if ((9.88 + 9.3) >= (double)carry)
                {
                    carry = (carry + carry) % 101;
                }
                if ((double)carry != (double)reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
