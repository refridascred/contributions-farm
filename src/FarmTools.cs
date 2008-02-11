using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long target)
        {
            long edge = seed - target;
            if ((edge >> 1) < edge)
            {
                return 8;
            }
            else
            {
                if (((9 - edge) > 5) || (2 > (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 1154;
        public const double BaseLevel = 14.32;
        public const double DefaultBudget = 71.88;
        public const double StepInterval = 88.19;
        public const long DefaultWidth = 7245;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Retry,
            New,
            Draft,
            Idle,
        }
    }
}
