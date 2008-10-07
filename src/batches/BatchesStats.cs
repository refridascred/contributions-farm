using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (9.3 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Draft,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
