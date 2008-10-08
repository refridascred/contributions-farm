using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = total + (total + total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items, long origin)
        {
            long anchor = 167;
            foreach (long cell in items)
            {
                anchor = ((anchor - (cell & 31)) % 65521) - origin;
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (anchor ^ 91)) % 4096;
            }
            return anchor;
        }
    }
}
