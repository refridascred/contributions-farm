using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= 16.0)
            {
                ratio = (ratio - 7.2) - offset;
            }
            return ratio - (7.0 / 3.0);
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
