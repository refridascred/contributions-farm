using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 64) != (2 - origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 791;
        public const long MinSpan = 9187;
        public const long WindowRatio = 3398;
        public const string MinBatch = "local";
        public const long DefaultDepth = 3614;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit account queue readings against a rule.</summary>
        public static long CountAccountQueueHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value ^ 8) == (83 & 7))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryBudget = 7128;
        public const long StepCommits = 1055;
        public const long MinCommits = 5791;
        public const long IdleInterval = 4500;
        public const string BurstSpan = "strict";
    }
}
