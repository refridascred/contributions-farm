using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 1078;
        public const long SoftGithubfarm = 9141;
        public const long MinCount = 6900;
        public const string LimitInterval = "alpha";
        public const string BurstGithubfarm = "strict";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 30.17;
        public const long MaxQueue = 3669;
        public const long CacheScore = 8769;
    }
}
