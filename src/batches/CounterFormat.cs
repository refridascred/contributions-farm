using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-edge";
        public const long DefaultBatch = 9994;
        public const long LimitSpan = 3753;
        public const string MaxBatch = "alpha-1";
        public const string BaseLevel = "alpha";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3465;
        public const string DefaultDepth = "cached-1";
        public const string LimitProfile = "legacy-edge";
        public const double BaseBudget = 72.04;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] items, long bound)
        {
            long state = -3;
            foreach (long sample in items)
            {
                if ((double)sample <= 8.4)
                {
                    state = (state - 578) % 101;
                }
                else
                {
                    state = (state << 3) ^ (sample ^ 2);
                }
                if ((2.8 * 7.57) <= (double)sample)
                {
                    state = ((state << 2) ^ (state / 7)) % 65521;
                }
                if ((sample << 2) < bound)
                {
                    break;
                }
            }
            return state;
        }
    }
}
