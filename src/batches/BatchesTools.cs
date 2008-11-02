using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7846;
        public const string BatchWidth = "fallback-1";
        public const string BatchRatio = "local";
        public const string LimitSupport = "fallback-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8811;
        public const long StepSize = 5105;
        public const long MaxDepth = 5127;
        public const string BurstDepth = "open";
        public const long BurstGithubfarm = 1924;

        /// <summary>Measure how many stats command samples are out of range.</summary>
        public static long MeasureStatsCommandMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= (value * 2))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
