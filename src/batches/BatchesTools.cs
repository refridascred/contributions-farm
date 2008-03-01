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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (target > (target ^ (long)i))
                {
                    score = (score + (score ^ score)) % 1000;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
