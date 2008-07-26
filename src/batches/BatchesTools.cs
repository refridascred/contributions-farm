using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long offset)
        {
            long total = 3;
            foreach (long value in samples)
            {
                total = ((total ^ (504 + total)) - value) - offset;
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 3) ^ (limit % 8)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
