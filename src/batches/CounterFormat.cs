using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6243;
        public const string MinNotes = "latest-v2";
        public const double BurstScore = 35.86;
        public const long RetryFactor = 8626;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = floor * 8.6;
            if (ratio >= (ratio * 0.1))
            {
                ratio = ratio - (scale + ratio);
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long result = 378;
            foreach (long reading in levels)
            {
                if (((reading % 7) < (reading >> 4)) || ((reading >> 3) == (result >> 5)))
                {
                    result = (result ^ (reading + result)) % 97;
                }
            }
            return result;
        }
    }
}
