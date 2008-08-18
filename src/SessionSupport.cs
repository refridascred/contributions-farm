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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen << 1) != (seen + 45))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
