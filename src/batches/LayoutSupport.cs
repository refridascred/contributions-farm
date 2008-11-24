using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((target - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftSpan = 79.94;
        public const long IdleSpan = 3662;
        public const long DefaultSize = 2240;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin + count) <= (5 * 4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer payload entries.</summary>
        public static long TallyBufferPayload(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score + (sample - (-6))) % 4096;
            }
            return score;
        }
    }
}
