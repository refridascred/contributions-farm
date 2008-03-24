using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) != (matches % 64)) && ((matches << 2) >= (712 * 5)))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3803;
        public const string RetryRatio = "latest-1";
        public const long LimitBudget = 5413;
        public const long DefaultWidth = 1043;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Pending,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
