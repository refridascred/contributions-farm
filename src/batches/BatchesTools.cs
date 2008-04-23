using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleCount = 84.33;
        public const long RetryFactor = 1940;
        public const double SoftGithubfarm = 62.73;
        public const string StepSize = "local-1";
        public const long BurstFactor = 4744;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double scale = (double)7;
            if (scale > (rate / 9.0))
            {
                scale = scale + (bias + scale);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - scale;
        }

        /// <summary>Locate a graph format reading by value.</summary>
        public static long LookupGraphFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
