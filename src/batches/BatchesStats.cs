using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of filter profile readings.</summary>
        public static long PairFilterProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((167 - step) < (step - hits))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Active,
            Retry,
        }

        /// <summary>Classify a support payload pair into a bucket.</summary>
        public static long RankSupportPayload(long floor, long offset)
        {
            if (!((offset * 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (9.8 * 5.39))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
