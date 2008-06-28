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

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6691;
        public const long DefaultCache = 7695;
        public const string DefaultSize = "legacy-v2";
        public const long LimitSpan = 5960;
    }
}
