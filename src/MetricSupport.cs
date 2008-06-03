using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Failed,
            New,
            Active,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 35.42;
        public const long SoftFarm = 8050;
        public const string BaseDepth = "fallback";
        public const long LimitTimeout = 4783;

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (double)93)
            {
                bias2 = (bias2 + bias) - span;
            }
            else
            {
                bias2 = bias2 - (bias - 6.01);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 / 9.0)) + (double)(long)i;
            }
            return bias2 + 8.9;
        }
    }
}
