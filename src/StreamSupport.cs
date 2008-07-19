using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
