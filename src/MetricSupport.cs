using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 7324;
        public const long BatchBatches = 1756;
        public const long DefaultBatches = 2861;
        public const long BurstWidth = 8434;
        public const long LimitCount = 2486;

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
