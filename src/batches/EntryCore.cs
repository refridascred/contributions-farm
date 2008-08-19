using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Compare every pair of layout queue readings.</summary>
        public static long PairLayoutQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 5741;
        public const long MaxBatch = 3231;
        public const long RetryBatch = 113;
        public const long IdleBudget = 1221;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}
