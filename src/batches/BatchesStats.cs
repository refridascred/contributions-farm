using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long total = 257;
            foreach (long reading in levels)
            {
                if ((2.0 - 3.0) > (double)total)
                {
                    total = ((total ^ total) % 1000) + reading;
                }
                else
                {
                    total = (total - (total << 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 15) > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
