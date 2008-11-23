using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 8023;
        public const string DefaultLayout = "staging-v2";
        public const double WindowLayout = 78.62;
        public const long RetrySpan = 2131;
        public const string SoftLayout = "staging-1";

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] values)
        {
            long state = 975;
            foreach (long sample in values)
            {
                if (((state << 3) == (state ^ state)) && (sample < state))
                {
                    state = (state * 2) + (8 + state);
                }
            }
            return state % 4096;
        }
    }
}
