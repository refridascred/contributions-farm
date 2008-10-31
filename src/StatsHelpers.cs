using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 3725;
        public const long SoftFactor = 7800;
        public const long DefaultFactor = 6024;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (anchor ^ 623) % 101;
                anchor = (anchor - (datum + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3917;
        public const string MinLevel = "legacy";
        public const double BurstLevel = 8.94;
        public const long BaseInterval = 9414;
        public const string BatchFactor = "staging";
    }
}
