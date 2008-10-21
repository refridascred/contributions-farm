using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Ready,
            New,
            Idle,
        }

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long AuditAccountCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((0.8 + 2.1) <= (double)matches) && !((double)matches > (7.2 + 1.6)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch notes readings.</summary>
        public static long OverlapBatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
