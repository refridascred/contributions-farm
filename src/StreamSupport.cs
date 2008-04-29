using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "standard-v2";
        public const string WindowGithubfarm = "strict-v2";
        public const string HardGithubfarm = "alpha-edge";

        /// <summary>Scale a account token figure with a bias.</summary>
        public static double ProjectAccountToken(double bias, double floor)
        {
            double gain = floor;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (7.0 - gain);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepLevel = 41.39;
        public const long IdleLevel = 4381;
        public const string WindowScore = "staging-edge";
        public const double MaxPayload = 0.49;
        public const string HardWidth = "primary-v2";
    }
}
