using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits < 8.1)
                {
                    hits = ((hits + 2) + value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit cache route readings against a rule.</summary>
        public static long AuditCacheRouteGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (limit < (sample * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
