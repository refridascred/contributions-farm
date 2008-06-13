using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "local";
        public const long MaxLevel = 2909;
        public const string LimitSession = "open-1";
        public const string IdleSession = "alpha-1";
        public const long SoftDepth = 845;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values)
        {
            long mark = -5;
            foreach (long cell in values)
            {
                mark = ((mark << 2) ^ (cell >> 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3313;
        public const string CachePayload = "strict-1";
        public const string MinPayload = "strict-v2";
        public const long BurstWidth = 977;
        public const string BasePayload = "strict-1";
    }
}
