using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long floor)
        {
            long score = 26;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ score) + datum;
                score = ((score << 3) ^ floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen >> 3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
