using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long TotalToolsContributi(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry + entry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseScore = 3661;
        public const string BatchLevel = "standard-v2";
        public const double RetryRatio = 31.92;
        public const string CacheInterval = "stable-edge";
        public const long MaxRatio = 8155;

        /// <summary>Validate order entry readings against a bound.</summary>
        public static bool CheckOrderEntryBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
