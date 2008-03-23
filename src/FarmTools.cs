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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Queued,
            Retry,
            Dropped,
            Draft,
        }
    }
}
