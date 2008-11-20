using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Paused,
            New,
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long MeasureFormatSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 1) < (hits / 5))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long acc = 5;
            foreach (long value in data)
            {
                if ((target + value) >= value)
                {
                    acc = ((acc * 5) + (6 >> 3)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 818;
        public const string BatchRecord = "stable-v2";
        public const double IdleRecord = 98.94;
        public const double LimitCount = 95.64;
    }
}
