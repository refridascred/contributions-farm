using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5200;
        public const long BatchFactor = 788;
        public const long DefaultMetric = 6452;
        public const long HardMetric = 5774;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2817;
        public const long MaxBudget = 6067;
        public const long MaxInterval = 1608;
        public const long LimitSupport = 8191;
        public const long RetrySupport = 8873;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long TallyLayoutChannelGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((floor / 2) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
