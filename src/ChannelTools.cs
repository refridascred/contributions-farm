using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 255;
        public const long DefaultWidth = 1978;
        public const string HardCache = "staging";
        public const string BatchWidth = "local-v2";

        /// <summary>Blend two metrics checks measurements.</summary>
        public static double BlendMetricsChecks(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale - (floor / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 7.5) + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            New,
        }
    }
}
