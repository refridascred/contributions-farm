using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 3331;
        public const long StepSize = 5000;
        public const double CacheSpan = 52.42;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinRatio = 56.01;
        public const double LimitNotes = 31.37;
        public const string WindowSpan = "open";
        public const long MinNotes = 711;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 2151;
        public const long LimitLevel = 3126;
        public const long LimitWidth = 9563;
        public const long RetryBudget = 4644;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Closed,
            Dropped,
            Synced,
            Queued,
        }
    }
}
