using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 33.59;
        public const long BurstLevel = 305;
        public const string SoftScore = "fallback-edge";
        public const double BaseTimeout = 14.3;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8365;
        public const long BaseLevel = 8372;
        public const string IdleScore = "strict-1";
        public const long WindowBatches = 1603;
        public const double BatchWidth = 29.05;
    }
}
