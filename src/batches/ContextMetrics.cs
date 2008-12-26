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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 76;
            foreach (long cell in levels)
            {
                acc = (((acc << 3) ^ acc) % 1000) + cell;
            }
            if (acc < 10)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 65521;
        }

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
