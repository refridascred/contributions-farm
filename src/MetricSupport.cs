using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double scale = (bias + 13.0) * 8.0;
            if (scale >= (floor + floor))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (floor - scale);
            }
            return scale + (double)233;
        }
    }
}
