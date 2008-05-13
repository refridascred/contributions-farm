using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            New,
            Active,
            Pending,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 35.23;
        public const long DefaultWindow = 6139;
        public const long RetryWindow = 3914;
        public const long BaseSpan = 6065;
        public const long WindowWidth = 5344;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((6.5 - 6.4) <= (double)matches)
                {
                    matches = ((matches + 1) ^ item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((938 & 1) < (item + bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
