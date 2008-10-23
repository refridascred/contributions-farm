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

        /// <summary>Validate notes checks readings against a bound.</summary>
        public static bool VerifyNotesChecksRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
