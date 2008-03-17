using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Closed,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5329;
        public const long BaseSize = 2653;
        public const long DefaultCount = 9874;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((8.6 + 19.0) >= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
