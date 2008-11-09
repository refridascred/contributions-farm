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

        /// <summary>Define record limits and defaults.</summary>
        public const string StepInterval = "open";
        public const string StepSpan = "open-1";
        public const long IdleRecord = 1420;
        public const double LimitRecord = 61.73;
        public const double StepScore = 20.04;

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
