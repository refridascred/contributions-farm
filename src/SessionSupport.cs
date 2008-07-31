using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)count < (3.6 / 7.0)))
                {
                    count = ((count + 1) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Ready,
            Active,
            Idle,
        }
    }
}
