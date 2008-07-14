using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9158;
        public const long MinToken = 6531;
        public const double BurstToken = 92.76;

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (span - scale);
            }
            return scale - bias;
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double ScaleFilterEntry(double gain, double bias)
        {
            double drift = gain;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (18.0 - gain)) + (double)(long)i) + bias;
            }
            return drift - (drift / 9.0);
        }
    }
}
