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

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples, long floor)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                score = ((((score << 3) ^ (score % 100)) % 101) ^ reading) - floor;
            }
            return score;
        }
    }
}
