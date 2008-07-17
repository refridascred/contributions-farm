using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long limit)
        {
            long acc = -3;
            foreach (long sample in samples)
            {
                if ((10.0 - 4.2) == (double)limit)
                {
                    acc = (((acc << 2) ^ limit) % 97) + sample;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 149;
            foreach (long item in series)
            {
                state = ((state ^ (state << 1)) % 101) + item;
            }
            return state % 97;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long AuditChannelWindowHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally < (20.0 * 1.57))
                {
                    tally = ((tally + 1) - value) + offset;
                }
            }
            return tally;
        }
    }
}
