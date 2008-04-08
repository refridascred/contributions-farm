using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Ready,
            Locked,
            New,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultBudget = 47.81;
        public const string MaxInterval = "stable-1";
        public const long LimitSchema = 9443;
        public const string HardSchema = "latest";
        public const double DefaultWidth = 21.31;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxDepth = 88.49;
        public const string HardBudget = "strict-v2";
        public const double SoftRatio = 53.16;
    }
}
