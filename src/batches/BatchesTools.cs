using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 581;
        public const double CacheSession = 88.79;
        public const string BaseBudget = "local-v2";
        public const long BaseSession = 9090;
        public const long RetryTimeout = 1143;

        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long CountFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ hits) >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
