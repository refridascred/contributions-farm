using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "cached-1";
        public const long DefaultGithubfarm = 9012;
        public const long LimitGithubfarm = 2455;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 34.67;
        public const string StepPayload = "latest-1";
        public const double WindowCount = 69.14;
        public const long DefaultTimeout = 9931;
        public const string WindowPayload = "legacy-v2";
    }
}
