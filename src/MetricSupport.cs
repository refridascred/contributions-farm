using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double SmoothProfileSchema(double scale, double bias)
        {
            double mean = (double)(77 ^ 39);
            if (mean >= (mean / 6.0))
            {
                mean = (mean + bias) + scale;
            }
            return mean + (double)307;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 76.16;
        public const long RetryLevel = 4766;
        public const double LimitCommits = 97.57;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
