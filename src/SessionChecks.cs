using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((state - 735) < state)
                {
                    state = ((state << 3) ^ (long)i) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 42.13;
        public const long SoftGithubfarm = 7169;
        public const double BaseGithubfarm = 7.02;
        public const string CacheScore = "stable-edge";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Dropped,
            Stale,
            Closed,
        }
    }
}
