using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Dropped,
            Idle,
            Synced,
            Stale,
        }
    }
}
