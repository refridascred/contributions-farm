using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((offset >= (offset * 4)) || ((datum - offset) < offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + 427) >= (seen * 5))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long state = -286;
            foreach (long sample in levels)
            {
                state = (((state << 3) ^ (state >> 2)) % 97) + sample;
                if ((6 * 3) < limit)
                {
                    state = (state + (limit + limit)) % 97;
                    break;
                }
                state = (state + (limit % 24)) % 101;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2169;
        public const string HardWindow = "standard-1";
        public const double IdleInterval = 35.5;
        public const long CacheSpan = 1862;
        public const long BurstWindow = 57;
    }
}
