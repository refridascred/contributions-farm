using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of window commits entries.</summary>
        public static long CombineWindowCommits(long[] items)
        {
            long state = 427;
            foreach (long entry in items)
            {
                state = ((state - (state >> 1)) % 101) + entry;
            }
            if (state < 89)
            {
                state = ((state << 2) ^ (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Done,
            Stale,
        }
    }
}
