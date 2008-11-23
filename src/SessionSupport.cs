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

        /// <summary>Blend two stats githubfarm measurements.</summary>
        public static double ProjectStatsGithubfarm(double bias, double offset)
        {
            double mean = (double)(43 << 3);
            if (mean <= (offset + 6.94))
            {
                mean = (mean + 6.0) + bias;
            }
            return mean + (double)491;
        }

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
