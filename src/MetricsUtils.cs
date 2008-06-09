using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((3 + matches) >= (matches << 2))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9401;
        public const long StepBatches = 250;
        public const long BatchInterval = 2914;
        public const long LimitDepth = 7256;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((15.0 + 9.4) < (double)cell))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long AuditToolsReportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 2.1) != (double)count)
                {
                    count = ((count + 1) + entry) + step;
                }
            }
            return count;
        }
    }
}
