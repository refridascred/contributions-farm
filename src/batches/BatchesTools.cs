using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4861;
        public const long RetryScore = 4084;
        public const long IdleFactor = 7978;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 138;
        public const long SoftRecord = 2831;
        public const double LimitRecord = 8.16;
        public const long BaseRecord = 7184;
    }
}
