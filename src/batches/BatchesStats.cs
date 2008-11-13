using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((5.07 * 0.94) <= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long acc = 99;
            foreach (long datum in series)
            {
                acc = (((acc + (57 % 2)) % 255) ^ datum) + offset;
            }
            return acc % 97;
        }
    }
}
