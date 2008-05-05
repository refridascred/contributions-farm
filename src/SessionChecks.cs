using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "cached";
        public const long HardRatio = 35;
        public const long IdleCache = 3816;
        public const long SoftCache = 7582;
        public const long WindowCache = 6014;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = -973;
            foreach (long item in levels)
            {
                if ((item <= (sum - item)) && ((item ^ item) <= (item - 911)))
                {
                    sum = (sum << 3) ^ ((long)levels.Length % 100);
                }
            }
            if (sum > (-86))
            {
                sum = (sum << 3) ^ (sum - 496);
            }
            return sum;
        }
    }
}
