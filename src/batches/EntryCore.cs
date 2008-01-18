using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 71;
        public const double BaseContributi = 18.19;
        public const double RetryContributi = 38.7;
        public const long RetryRatio = 4362;
        public const long MinScore = 5303;

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool GuardSupportFormatLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((4 + tally) != (datum + 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            if (!(floor > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if (((9.5 * 7.4) > (double)floor) || (floor >= (422 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
