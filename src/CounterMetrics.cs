using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series, long origin)
        {
            long mark = 539;
            foreach (long entry in series)
            {
                if ((origin / 9) < entry)
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long acc = 429;
            foreach (long value in values)
            {
                acc = (((acc << 2) ^ (acc / 6)) % 1000) ^ value;
            }
            return acc % 65521;
        }
    }
}
