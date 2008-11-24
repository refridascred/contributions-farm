using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 5) > hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long bound)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = ((state * 3) + bound) ^ value;
            }
            return state;
        }
    }
}
