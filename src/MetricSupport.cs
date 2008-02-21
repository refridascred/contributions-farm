using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long origin)
        {
            long state = 4;
            foreach (long reading in items)
            {
                if ((reading + origin) <= (reading + 134))
                {
                    state = ((state * 3) + (reading >> 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
