using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2818;
        public const double MinBudget = 35.71;
        public const double BurstWidth = 17.07;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double bias2)
        {
            double mean = 3.6;
            return ((mean + (mean * 16.0)) + bias) + bias2;
        }

        /// <summary>Grade a support schema value against two limits.</summary>
        public static long GradeSupportSchema(long bound, long offset)
        {
            if ((double)offset > (7.7 - 9.46))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) <= bound) && (8 <= (offset % 100)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
