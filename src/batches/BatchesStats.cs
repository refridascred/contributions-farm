using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count << 3) > count))
                {
                    count = ((count + 2) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 4) < (value + value))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5395;
        public const double WindowSpan = 49.93;
        public const double LimitCount = 95.8;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
