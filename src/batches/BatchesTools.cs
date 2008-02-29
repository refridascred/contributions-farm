using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 369;
        public const string StepDepth = "stable-1";
        public const long DefaultLayout = 5544;
        public const long BatchLayout = 2074;

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
