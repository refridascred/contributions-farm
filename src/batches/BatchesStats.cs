using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((13.0 - 9.5) == (double)state))
                {
                    state = (state << 2) ^ state;
                }
                if ((state + cell) > (state % 2))
                {
                    state = (state << 2) ^ (state >> 5);
                }
            }
            if (state > 494)
            {
                state = (state + (state + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 64.33;
        public const long DefaultRatio = 9685;
        public const long HardGithubfarm = 5775;
        public const long SoftBudget = 1428;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 4766;
        public const long MaxScore = 2501;
        public const double LimitFactor = 30.38;
        public const string CacheGithubfarm = "staging-edge";
        public const string BurstCount = "local-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchRatio = 49.96;
        public const long RetryRatio = 2156;
        public const long SoftLevel = 3502;
    }
}
