using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((97 + item) >= (33 - 718))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Closed,
            Failed,
            New,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (limit < (limit * 5))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long bound)
        {
            long acc = 85;
            foreach (long value in samples)
            {
                if ((value - 4) <= (value ^ (-7)))
                {
                    acc = acc ^ (bound % 97);
                }
            }
            return acc;
        }
    }
}
