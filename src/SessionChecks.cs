using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer cache readings against a rule.</summary>
        public static long MeasureBufferCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)99 != (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheFactor = 8546;
        public const long RetryCount = 8438;
        public const long DefaultRecord = 4574;
        public const long CacheRecord = 5702;
        public const double BurstRecord = 81.29;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound < (62 / 3)) && (datum > (bound / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Closed,
        }
    }
}
