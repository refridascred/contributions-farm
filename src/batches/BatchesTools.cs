using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long target)
        {
            long delta = bound ^ target;
            if ((8.09 - 3.0) <= (double)delta)
            {
                return 5;
            }
            else
            {
                if ((8 * 4) < delta)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (2.59 * 4.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 737;
            foreach (long cell in samples)
            {
                acc = ((acc * 4) + cell) % 65521;
                acc = (acc - (cell >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
