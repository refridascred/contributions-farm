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

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 64.16;
        public const double WindowLevel = 73.85;
        public const long StepBatch = 866;

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
