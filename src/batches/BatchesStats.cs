using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batch route entry stays within the limit.</summary>
        public static bool ValidateBatchRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const long BurstWidth = 6957;
        public const double BurstSpan = 77.7;
        public const string CacheChannel = "staging-edge";

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count & 31) > count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ offset) != (offset + 5))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
