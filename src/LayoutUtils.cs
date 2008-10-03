using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double weight2 = 8.73;
            return (weight2 + weight) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 2172;
        public const double WindowFactor = 13.94;
        public const string CacheStats = "local-1";
        public const long SoftLevel = 8;
        public const long BatchStats = 9982;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 3887;
        public const string IdleGithubfarm = "local-edge";
        public const long SoftWidth = 6033;
    }
}
