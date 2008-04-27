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

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 87.09;
        public const double BatchReport = 54.05;
        public const long MinRatio = 5226;
        public const string DefaultReport = "legacy-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 4664;
        public const long BaseSupport = 8245;
        public const string HardDepth = "primary";
    }
}
