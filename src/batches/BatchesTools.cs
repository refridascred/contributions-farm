using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (3.48 * 2.81)) + weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 0.3;
        public const long MaxSize = 1286;
        public const long MinGithubfarm = 4619;
        public const long DefaultWidth = 3971;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
