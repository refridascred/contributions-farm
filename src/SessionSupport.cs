using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long origin)
        {
            if (((double)target >= (11.0 * 7.0)) || ((target + origin) < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if (origin < (target % 100))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            New,
            Active,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2379;
        public const double DefaultLevel = 6.23;
        public const long StepProfile = 4166;
        public const long SoftCount = 901;
        public const long SoftInterval = 1607;
    }
}
