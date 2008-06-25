using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value < 603)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Closed,
            Pending,
            Stale,
        }
    }
}
