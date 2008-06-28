using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "staging-v2";
        public const string IdleScore = "cached";
        public const string MaxCount = "stable-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 5519;
        public const double StepTimeout = 40.93;
        public const long SoftLevel = 1960;
        public const string RetryStream = "legacy-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 6575;
        public const long LimitChecks = 2110;
        public const double WindowRatio = 23.88;
        public const long BatchWidth = 7223;
    }
}
