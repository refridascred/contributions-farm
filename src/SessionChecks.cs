using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Dropped,
            Active,
            Ready,
            Stale,
        }
    }
}
