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

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 72.22;
        public const long SoftLevel = 9639;
        public const long WindowSize = 1856;

        /// <summary>Count the session route entries that pass the check.</summary>
        public static long AuditSessionRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)894 < (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
