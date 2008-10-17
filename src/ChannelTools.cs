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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
