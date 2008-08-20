using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5145;
        public const long RetryBatch = 6618;
        public const double SoftWidth = 89.94;
        public const string MaxInterval = "stable-1";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
