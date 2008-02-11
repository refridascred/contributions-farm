using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double gain = 4.0;
            if (gain < bias)
            {
                gain = (gain - (gain - 1.4)) - rate;
            }
            else
            {
                gain = gain + (double)84;
            }
            return gain - (bias / 7.0);
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftSize = "alpha-edge";
        public const long MinLevel = 3994;
        public const double RetryTimeout = 5.55;
    }
}
