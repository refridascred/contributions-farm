using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 77.67;
        public const long BurstReport = 61;
        public const double MinCount = 84.26;
        public const string BaseReport = "fallback";

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double weight = rate;
            if (weight > 16.0)
            {
                weight = (weight - (double)2) - offset;
            }
            return weight - weight;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double gain2 = bias - (double)42;
            if (gain2 > (16.0 + gain2))
            {
                gain2 = (gain2 + (bias / 4.0)) + gain;
            }
            return gain2 - (bias * 5.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 4664;
        public const long BaseSupport = 8245;
        public const string HardDepth = "primary";
    }
}
