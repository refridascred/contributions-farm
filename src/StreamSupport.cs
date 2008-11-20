using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "standard-v2";
        public const double WindowAccount = 86.35;
        public const string LimitFactor = "stable";
        public const long BurstSpan = 7343;
        public const long MaxAccount = 2581;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7347;
        public const string LimitGithubfarm = "latest-1";
        public const string WindowGithubfarm = "staging-edge";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((28 + tally) == (item * 5))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
