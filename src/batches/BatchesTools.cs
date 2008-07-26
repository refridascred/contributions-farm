using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 4578;
        public const long RetrySize = 1720;
        public const string MaxWidth = "legacy-edge";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Active,
            New,
            Ready,
        }

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long AuditStreamClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
