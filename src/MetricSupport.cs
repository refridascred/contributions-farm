using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((offset >> 3) >= count)
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 9586;
        public const string BatchSchema = "fallback-1";
        public const long CacheCount = 9275;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Failed,
            New,
            Paused,
            Idle,
        }
    }
}
