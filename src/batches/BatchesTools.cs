using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits ^ offset) > (offset * 4))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long ScoreBatchesContext(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (item << 1)) % 65521;
                    total = (total << 2) ^ ((long)i ^ item);
                }
                if (total > item)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
