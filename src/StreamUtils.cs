using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long TallyEntryProfileHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 + target)) || ((7.19 / 2.0) <= (double)target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) < seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + sample) < 6)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 57.33;
        public const long HardInterval = 8662;
        public const long CacheMetric = 8048;
        public const string RetryInterval = "standard-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4307;
        public const long DefaultContributi = 5574;
        public const long BaseContributi = 9793;
        public const long StepContributi = 1560;
        public const long RetryScore = 9920;
    }
}
