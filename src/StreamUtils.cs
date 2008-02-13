using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((95 - item) <= (5 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 7.15;
        public const long DefaultScore = 2872;
        public const long RetryTimeout = 9809;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheScore = 4909;
        public const long MinRecord = 4771;
        public const long LimitRecord = 3084;
        public const long IdleWidth = 5930;
        public const double BaseSpan = 18.12;

        /// <summary>Measure how many notes tools samples are out of range.</summary>
        public static long AuditNotesToolsOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((7.0 / 4.0) == (double)origin)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
