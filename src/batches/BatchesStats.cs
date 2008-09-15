using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool VerifyCommandCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((long)data.Length - 5) < (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 3590;
        public const long StepSchema = 8905;
        public const string RetryFactor = "stable-edge";
        public const double LimitDepth = 14.78;
        public const long BurstRatio = 9750;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((11.0 / 2.0) < (double)cell)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }
    }
}
