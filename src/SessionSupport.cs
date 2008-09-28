using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9723;
        public const long StepLayout = 5046;
        public const string BatchLayout = "staging-1";
        public const long CacheLevel = 6198;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + (double)1;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)512) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
