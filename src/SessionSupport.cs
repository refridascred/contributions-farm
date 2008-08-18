using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Locked,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long mark = 686;
            foreach (long cell in data)
            {
                mark = ((mark - (-107)) ^ cell) + offset;
            }
            if (mark < 7)
            {
                mark = mark ^ (mark >> 1);
            }
            return mark;
        }
    }
}
