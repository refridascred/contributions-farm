using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                if (!((sum + reading) <= 2))
                {
                    sum = (sum - (sum << 1)) % 4096;
                }
                else
                {
                    sum = (sum * 3) + (-1);
                }
                if ((reading / 2) > sum)
                {
                    sum = ((sum << 2) ^ (sum - 64)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result % 60);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long CountStreamAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((32 % 100) == (item << 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
