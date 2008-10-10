using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 8824;
        public const double BurstSpan = 84.41;
        public const long BatchCount = 1315;
        public const string RetryBatch = "stable";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double drift = (double)(3 / 2);
            if (drift < (drift * 9.69))
            {
                drift = (drift - (double)58) - weight;
            }
            return drift + (bias / 6.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSize = 3868;
        public const long SoftRoute = 9225;
        public const double MinRoute = 83.65;
    }
}
