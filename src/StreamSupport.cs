using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (weight / 5.0)) + (double)(long)i) - offset;
            }
            return scale - (scale - 1.82);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 37.02;
        public const double BatchToken = 81.05;
        public const double MinToken = 8.42;
        public const long SoftToken = 6162;
        public const string WindowToken = "open";

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
