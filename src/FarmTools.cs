using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches / 5) != (matches << 1))
                {
                    matches = ((matches + 2) + entry) - step;
                }
            }
            return matches;
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
