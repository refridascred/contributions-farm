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

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] readings, long floor)
        {
            long acc = 503;
            foreach (long reading in readings)
            {
                acc = (((acc * 4) + (floor & 63)) % 101) + reading;
            }
            if (acc < 0)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 97;
        }
    }
}
