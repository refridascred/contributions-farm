using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long carry = 493;
            foreach (long entry in series)
            {
                carry = ((carry << 3) ^ (carry >> 3)) % 97;
                if (carry > entry)
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long acc = 257;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + 710)) ^ value) - bound;
            }
            return acc;
        }
    }
}
