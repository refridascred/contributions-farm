using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseBudget = 9406;
        public const double HardGithubfarm = 98.19;
        public const double IdleSpan = 21.73;
        public const double MinCount = 0.09;
        public const long WindowTimeout = 3381;

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool ValidateTokenCommandRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] series)
        {
            long score = 53;
            foreach (long datum in series)
            {
                score = (score ^ (10 + datum)) % 65521;
            }
            return score;
        }
    }
}
