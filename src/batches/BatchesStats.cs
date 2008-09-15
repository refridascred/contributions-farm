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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                if (anchor >= (item - item))
                {
                    anchor = (anchor ^ (item % 16)) % 255;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (item <= (anchor % 8))
                {
                    break;
                }
            }
            return anchor;
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
