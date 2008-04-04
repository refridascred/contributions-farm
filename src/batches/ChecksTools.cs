using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean + 6.9) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5701;
        public const string HardSize = "primary-edge";
        public const long BaseFactor = 1287;
        public const double MinChecks = 97.78;
        public const double HardChecks = 50.38;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 6849;
        public const long DefaultGithubfarm = 4038;
        public const string RetryGithubfarm = "stable-v2";
    }
}
