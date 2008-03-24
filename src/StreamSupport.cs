using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleTimeout = 6128;
        public const string HardLevel = "fallback-v2";
        public const string StepSpan = "legacy-1";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((double)limit >= 5.34) && ((0.1 * 8.49) != (double)state))
                {
                    state = ((state << 2) ^ (670 << 2)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9336;
        public const long BurstRecord = 3214;
        public const double WindowRatio = 6.81;
        public const string BatchLevel = "strict-1";
        public const long LimitScore = 1240;
    }
}
