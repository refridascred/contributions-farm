using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long offset2)
        {
            if ((1 ^ 287) > (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((offset + (-441)) > offset2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "open-edge";
        public const string IdleTimeout = "staging-v2";
        public const double CacheMetrics = 69.85;
        public const long DefaultMetrics = 873;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Stale,
            Draft,
            Retry,
            Pending,
        }
    }
}
