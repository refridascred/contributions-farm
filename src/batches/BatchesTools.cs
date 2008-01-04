using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 8718;
        public const long IdleGithubfarm = 5939;
        public const double HardLevel = 44.27;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double gain = (double)(591 + 99);
            if (gain < (bias + bias))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain - 6.0;
            }
            return gain - (7.3 / 8.0);
        }
    }
}
