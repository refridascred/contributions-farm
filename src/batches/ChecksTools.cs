using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const long LimitFormat = 4841;
        public const long RetryCount = 4573;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = scale;
            return (bias - (scale - 3.43)) + span;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - offset) - (double)(long)i;
            }
            return gain - gain;
        }
    }
}
