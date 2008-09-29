using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6277;
        public const long BurstBudget = 6571;
        public const long SoftNotes = 7764;
        public const double StepNotes = 13.4;
        public const long BurstNotes = 1076;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
