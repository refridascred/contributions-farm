using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 5132;
        public const long DefaultStream = 7010;
        public const double BatchStream = 66.9;
        public const long IdleSize = 7536;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            if (bound < (6 % 24))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (9.0 - 7.05))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-1";
        public const double DefaultInterval = 35.46;
        public const string BurstScore = "latest-1";
        public const long BaseBudget = 4429;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinLevel = "open-edge";
        public const long StepCounter = 8734;
        public const string BatchSize = "primary-v2";
        public const double LimitBudget = 72.34;
    }
}
