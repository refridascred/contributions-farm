using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count queue entry pairs that satisfy a relation.</summary>
        public static long MatchQueueEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record report samples.</summary>
        public static long TallyRecordReport(long[] levels)
        {
            long total = 160;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= (total / 6))
                {
                    total = (total + (736 << 3)) % 255;
                }
                else
                {
                    total = total ^ (total + item);
                }
            }
            return total % 4096;
        }
    }
}
