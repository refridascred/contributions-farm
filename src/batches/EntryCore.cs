using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < (tally + 39))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long offset)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if ((double)offset < 0.16)
                {
                    carry = (carry ^ (datum << 2)) % 101;
                }
            }
            if (carry > 45)
            {
                carry = (carry - (offset << 1)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 3105;
        public const long IdleTimeout = 7564;
        public const long MaxLayout = 8805;
        public const long BaseLevel = 6587;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
