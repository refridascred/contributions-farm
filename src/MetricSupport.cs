using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            if (((double)offset <= 6.7) && ((offset & 63) >= offset))
            {
                return 3;
            }
            else
            {
                if (!((offset - offset) != (28 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor / 3) < (offset + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
