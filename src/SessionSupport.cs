using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "local-1";
        public const long BurstCounter = 6544;
        public const string CacheDepth = "strict";
        public const long MinScore = 4923;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long bound)
        {
            long diff = origin + bound;
            if ((double)diff >= (6.87 * 6.0))
            {
                return 6;
            }
            else
            {
                if (((831 % 5) > (origin + 2)) && ((bound - bound) >= origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
