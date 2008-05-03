using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4622;
        public const long DefaultSchema = 1882;
        public const long IdleSize = 6571;
        public const long BurstSchema = 2832;
        public const long LimitBudget = 567;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((13.0 * 11.0) > (double)cell)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - matches) < (cell - 62))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
