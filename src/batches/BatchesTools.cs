using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen <= (6.24 / 7.0))
                {
                    seen = ((seen + 1) ^ datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a order githubfarm reading.</summary>
        public static double AdjustOrderGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale > floor)
            {
                scale = scale + scale;
            }
            return scale + (double)58;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultSize = "fallback-edge";
        public const long WindowWidth = 3989;
        public const long LimitBudget = 6975;
        public const string StepCount = "legacy-v2";
        public const string BaseSize = "staging-1";
    }
}
