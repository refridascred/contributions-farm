using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "staging-v2";
        public const long IdleLevel = 2586;
        public const long CacheWidth = 9734;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9849;
        public const long BurstTools = 2610;
        public const long DefaultTools = 506;
        public const long BaseTools = 4922;
        public const long StepSpan = 1482;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 5416;
        public const long CacheRecord = 3168;
        public const double StepRecord = 57.93;
        public const double MinRecord = 97.33;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count - reading) < count) || ((9.29 <= (double)count) || (reading > origin)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
