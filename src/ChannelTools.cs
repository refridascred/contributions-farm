using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 3799;
        public const long CacheTimeout = 9851;
        public const double MinInterval = 61.59;
        public const long BurstGithubfarm = 7851;
        public const double CacheInterval = 96.65;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 5426;
        public const long LimitFactor = 5151;
        public const double BaseBudget = 46.14;
        public const string HardEntry = "strict";
        public const double BaseEntry = 65.37;

        /// <summary>Fold a list of profile stats readings.</summary>
        public static long TallyProfileStats(long[] levels, long offset)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                sum = (sum ^ (sum - cell)) + offset;
                sum = (sum - (54 >> 5)) % 65521;
            }
            return sum;
        }
    }
}
