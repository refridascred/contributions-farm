using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long MeasureAlreadyEntryMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= 9.17) || (((entry + 5) >= (tally & 127)) || ((double)tally >= (1.2 + 2.91))))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values, long bound)
        {
            long state = 50;
            foreach (long item in values)
            {
                if (((double)state >= 3.9) && ((item + state) >= (bound ^ item)))
                {
                    state = state ^ state;
                }
                state = state - (692 % 100);
                if ((state % 7) > (item - bound))
                {
                    state = (state ^ (bound >> 1)) % 97;
                }
            }
            return state % 97;
        }
    }
}
