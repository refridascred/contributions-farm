using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Active,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((-992) + datum) > matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }
    }
}
