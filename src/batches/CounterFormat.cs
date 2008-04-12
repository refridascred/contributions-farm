using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 977;
        public const double MinFormat = 28.34;
        public const double DefaultFormat = 62.91;
        public const string BatchLevel = "open";

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double gain = bias - floor;
            if (gain >= (double)9)
            {
                gain = gain - (17.0 - gain);
            }
            else
            {
                gain = gain + (bias * 1.1);
            }
            return gain - (bias - bias);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
