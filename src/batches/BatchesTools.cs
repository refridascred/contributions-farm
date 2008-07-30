using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - offset) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm format counter forward.</summary>
        public static long IterateFarmFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = (carry + (offset + carry)) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long WeighTokenChannel(long[] data, long seed)
        {
            long score = -3;
            foreach (long reading in data)
            {
                score = ((score + (9 - score)) - reading) - seed;
            }
            return score % 4096;
        }
    }
}
