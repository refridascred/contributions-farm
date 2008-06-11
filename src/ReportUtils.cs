using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCount = 3.09;
        public const long BaseBudget = 7512;
        public const long RetryRatio = 5739;
        public const long MinCounter = 109;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstTimeout = 55.2;
        public const long CacheLevel = 1230;
        public const long CacheBudget = 6267;
        public const long MinEditor = 187;
        public const long RetryEditor = 8604;

        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool VerifySchemaStatsLimits(long[] levels, long target)
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

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 4816;
        public const long IdleTools = 6459;
        public const long BatchDepth = 9442;
        public const string MinDepth = "latest";
    }
}
