using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= 96)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinBudget = "open-1";
        public const long MaxTimeout = 9906;
        public const long DefaultCount = 9960;
        public const long BatchAccount = 553;
        public const long BurstAccount = 8848;
    }
}
