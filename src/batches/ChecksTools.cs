using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long score = 35;
            foreach (long datum in levels)
            {
                score = ((score - (score * 2)) % 1000) + datum;
                score = (score - score) % 65521;
            }
            if (score < 4)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Done,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
