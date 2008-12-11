using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 8771;
        public const double BatchAlready = 12.0;
        public const long SoftAlready = 6707;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next support payload value.</summary>
        public static double SmoothSupportPayload(double ratio, double bias)
        {
            double rate = (double)(68 - 809);
            if (rate >= (double)(-1))
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 55.24;
        public const double BatchDepth = 1.49;
        public const long BatchRatio = 3105;
        public const double SoftSpan = 32.78;
        public const long BurstScore = 6247;
    }
}
