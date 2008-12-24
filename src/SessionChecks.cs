using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 63.28;
        public const string WindowDepth = "stable-1";
        public const long MaxSize = 3253;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFactor = 3965;
        public const long WindowTimeout = 5982;
        public const double RetryFarm = 24.18;
        public const double HardFarm = 4.77;

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double gain = 5.5;
            if (gain < (double)129)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (span + 17.0)) + (double)(long)i;
            }
            return gain - (double)(-980);
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
