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

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                total = ((total - reading) % 4096) - offset;
            }
            if (total < 90)
            {
                total = (total - total) % 4096;
            }
            return total % 4096;
        }
    }
}
