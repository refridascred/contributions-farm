using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long limit)
        {
            if ((limit >> 3) >= (origin % 64))
            {
                return 0;
            }
            else
            {
                if ((95 - origin) == (origin >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (4.0 - 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
