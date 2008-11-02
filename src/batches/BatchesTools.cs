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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long tally = total * 5;
                if (5 < (tally + 700))
                {
                    tally = tally ^ (offset * 4);
                }
                else
                {
                    tally = tally ^ (total + total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
