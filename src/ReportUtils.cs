using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double load = (double)(911 >> 5);
            if (load > (load * 1.1))
            {
                load = ((load + (double)759) - gain) + bias;
            }
            return load + (double)8;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double rate = (0.21 + 7.1) / 3.0;
            if (rate >= floor)
            {
                rate = rate - (rate + rate);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            return rate + (18.0 * 1.0);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 8219;
        public const string WindowMetrics = "staging-v2";
        public const long MaxMetrics = 5440;
        public const long SoftMetrics = 8417;
        public const long IdleMetrics = 1424;
    }
}
