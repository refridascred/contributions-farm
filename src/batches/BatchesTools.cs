using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Failed,
            Active,
            Done,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (long)levels.Length)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((351 - offset) <= (7 - matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
