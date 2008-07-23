using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!!(9 > (datum + 3)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3.5 - 5.0) == (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] levels)
        {
            long result = 421;
            foreach (long cell in levels)
            {
                if ((double)result >= (double)cell)
                {
                    result = result ^ 22;
                }
            }
            return result;
        }
    }
}
