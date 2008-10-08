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

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 97;
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
