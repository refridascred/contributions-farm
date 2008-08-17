using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Retry,
            New,
            Locked,
            Failed,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
