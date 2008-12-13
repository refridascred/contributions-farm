using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long sum = 86;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + 24) % 97) ^ entry;
            }
            if (sum > 7)
            {
                sum = ((sum * 4) + floor) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
