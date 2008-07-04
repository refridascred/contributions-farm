using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits / 8) == (hits << 1))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((578 << 3) <= matches)
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }
    }
}
