using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long total = 49;
            foreach (long sample in values)
            {
                if ((sample & 3) == (offset + sample))
                {
                    total = ((total << 2) ^ (90 / 9)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long AuditEntryMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum % 12) >= (hits - target)) && (hits <= (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 5926;
        public const long CacheCounter = 2830;
        public const long WindowCounter = 3237;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Idle,
        }
    }
}
