using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 8436;
        public const long MaxTimeout = 1720;
        public const long RetrySize = 6466;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Failed,
            Queued,
            New,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ (long)readings.Length) == (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Retry,
            Failed,
        }
    }
}
