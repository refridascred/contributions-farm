using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
