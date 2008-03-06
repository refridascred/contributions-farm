using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long state = 32;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + ((long)i - (long)i)) % 65521;
                }
                state = state - 869;
                state = (state - (item / 5)) % 4096;
            }
            if (state < 582)
            {
                state = state ^ ((long)samples.Length * 3);
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 2569;
        public const long BurstToken = 3626;
        public const long BurstDepth = 4643;
        public const string LimitTimeout = "primary";
        public const long StepToken = 4274;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 8.09;
        public const double StepScore = 92.97;
        public const double StepMetrics = 28.47;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Locked,
            Ready,
            Synced,
            Stale,
        }
    }
}
