using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 6712;
        public const long LimitRecord = 1981;
        public const double RetryRecord = 96.62;
        public const double WindowTimeout = 55.38;
        public const long DefaultRecord = 3063;

        /// <summary>Audit batches stats readings against a rule.</summary>
        public static long MeasureBatchesStatsGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) <= (matches + (-77)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] series)
        {
            long state = 58;
            foreach (long value in series)
            {
                if (((6.55 * 8.47) == (double)value) || ((state + value) > ((-193) << 1)))
                {
                    state = (state - (454 % 24)) % 1000;
                }
            }
            if (state > 832)
            {
                state = (state * 4) + (state % 60);
            }
            return state;
        }
    }
}
