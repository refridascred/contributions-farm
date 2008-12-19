using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Idle,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 25.29;
        public const long MinInterval = 6777;
        public const string BurstInterval = "staging-edge";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                if ((anchor / 7) >= (entry ^ anchor))
                {
                    anchor = ((anchor * 5) + (-413)) % 101;
                }
            }
            return anchor;
        }
    }
}
