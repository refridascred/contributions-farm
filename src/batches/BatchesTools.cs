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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if (!!((5.5 + 0.66) >= (double)item))
                {
                    mix = (mix + (mix + item)) % 65521;
                }
                if (9 >= mix)
                {
                    mix = (mix + mix) % 1000;
                }
            }
            if (mix < 599)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
