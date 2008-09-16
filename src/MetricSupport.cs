using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] values)
        {
            long sum = 95;
            foreach (long entry in values)
            {
                sum = (sum ^ (sum >> 1)) % 1000;
                if (entry < (203 + 2))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 62.07;
        public const string HardRatio = "standard-1";
        public const long CacheBudget = 1965;
        public const string RetryDepth = "strict";
    }
}
