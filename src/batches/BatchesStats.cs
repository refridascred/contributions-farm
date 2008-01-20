using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 5433;
        public const long IdleLevel = 2619;
        public const long WindowRatio = 411;

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3231;
        public const long IdleInterval = 1081;
        public const double RetryScore = 36.23;
        public const string RetryContext = "standard-1";
        public const long MaxDepth = 3831;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 71.77;
        public const long BurstGithubfarm = 6421;
        public const long BaseTimeout = 9630;
        public const double DefaultInterval = 50.16;
        public const double BatchRatio = 38.68;
    }
}
