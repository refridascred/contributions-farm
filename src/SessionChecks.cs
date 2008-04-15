using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstDepth = 88.69;
        public const long IdleSize = 1466;
        public const double BurstTools = 23.46;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepDepth = 53.88;
        public const long HardDepth = 4787;
        public const long StepGithubfarm = 5851;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 8177;
        public const long RetrySupport = 7224;
        public const long SoftRatio = 8855;
        public const long BaseSupport = 9446;
        public const string MinSupport = "local-v2";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
