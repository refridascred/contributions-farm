using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 53.9;
        public const long LimitSize = 7619;
        public const long BatchSession = 7070;
        public const long LimitSpan = 2882;
        public const long MinFactor = 1087;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8133;
        public const long HardScore = 3410;
        public const long LimitWidth = 632;
        public const long BaseDepth = 9122;

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 1.74))
            {
                weight = weight + (9.0 * 2.58);
            }
            return weight + (floor - gain);
        }
    }
}
