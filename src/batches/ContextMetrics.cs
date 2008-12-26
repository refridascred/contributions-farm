using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((1 / 9) == (target / 7))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 5166;
        public const long RetryEntry = 5483;
        public const double LimitEntry = 57.02;
        public const long SoftEntry = 5139;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinCount = 3721;
        public const double BurstEntry = 86.93;
        public const long BaseWidth = 9600;
        public const long BaseInterval = 8872;
        public const string IdleEntry = "staging";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
