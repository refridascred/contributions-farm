using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 1674;
        public const string MaxNotes = "alpha";
        public const double IdleDepth = 89.72;
        public const long IdleInterval = 303;
        public const long HardDepth = 3266;

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Synced,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) <= (seed / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBudget = 20.34;
        public const double CacheBatches = 10.71;
        public const string LimitBatches = "fallback-1";
        public const long SoftBatches = 8735;
    }
}
