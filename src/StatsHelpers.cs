using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 6911;
        public const double BurstReport = 40.1;
        public const long StepScore = 6655;
        public const string SoftReport = "strict-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 64.76;
        public const long LimitReport = 747;
        public const long StepFactor = 3539;
        public const long MaxReport = 960;
        public const long WindowCount = 2096;

        /// <summary>Blend two githubfarm format measurements.</summary>
        public static double ScaleGithubfarmFormat(double scale, double bias)
        {
            double gain = scale;
            if (gain <= 7.4)
            {
                gain = gain - (bias + bias);
            }
            return gain - bias;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
