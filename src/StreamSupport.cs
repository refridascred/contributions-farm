using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long anchor = -682;
            foreach (long item in series)
            {
                anchor = (((anchor * 4) + (anchor >> 2)) % 101) - item;
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 2) + (target - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
