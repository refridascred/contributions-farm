using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm commits values into a single score.</summary>
        public static long FoldGithubfarmCommits(long[] values, long target)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = (total - datum) + target;
                if ((total & 7) <= (59 & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            New,
            Idle,
        }
    }
}
