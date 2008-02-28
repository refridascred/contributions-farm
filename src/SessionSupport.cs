using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long CountGithubfarmSessionMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((99 <= origin) || ((hits % 12) != (238 >> 2)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine context queue values into a single score.</summary>
        public static long FoldContextQueue(long[] series, long offset)
        {
            long state = 50;
            foreach (long datum in series)
            {
                state = (state - (datum & 63)) - offset;
            }
            return state;
        }
    }
}
