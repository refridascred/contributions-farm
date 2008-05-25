using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item ^ origin) < 331))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
