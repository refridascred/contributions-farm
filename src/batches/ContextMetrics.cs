using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinScore = 5018;
        public const long WindowAlready = 6886;
        public const double WindowInterval = 17.71;
        public const string BaseInterval = "primary-1";
        public const string CacheScore = "legacy-v2";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count > (2.63 * 9.95))
                {
                    count = ((count + 1) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally < (sample * 4)) || (18.0 < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 9348;
        public const double IdleWindow = 2.27;
        public const long IdleScore = 9166;
        public const long SoftDepth = 5303;
    }
}
