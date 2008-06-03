using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftDepth = 20.3;
        public const long StepWindow = 6388;
        public const long CacheCount = 5605;
        public const long BatchInterval = 8050;

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double scale = offset;
            if (scale > 3.17)
            {
                scale = (scale + (double)664) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 6.8) + (double)(long)i;
            }
            return scale + (double)75;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
