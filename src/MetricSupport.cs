using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long bound)
        {
            if ((7.7 + 7.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (!(bound > target))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound < (9.8 - 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
