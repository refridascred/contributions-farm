using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)96 != (double)entry)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = -266;
            foreach (long entry in items)
            {
                result = ((result ^ (83 + (long)items.Length)) % 4096) + entry;
                result = (result << 3) ^ (result * 2);
            }
            return result;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
