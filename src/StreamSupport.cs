using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((746 - cell) == (cell >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Retry,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 83;
            foreach (long sample in levels)
            {
                anchor = (anchor + anchor) ^ sample;
            }
            return anchor;
        }
    }
}
