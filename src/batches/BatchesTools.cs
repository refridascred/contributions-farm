using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank token contributi input into a small class.</summary>
        public static long SortTokenContributi(long target, long bound)
        {
            long delta = target ^ bound;
            if (delta <= bound)
            {
                return 5;
            }
            else
            {
                if (((4 % 60) != (bound / 3)) && (bound < delta))
                {
                    return 8;
                }
                else
                {
                    if (((double)delta < 17.0) || (20.0 <= (double)delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 2) >= (bound - 114))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Queued,
            Dropped,
            Failed,
            Draft,
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
