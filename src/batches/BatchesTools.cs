using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a already report reading by value.</summary>
        public static long SeekAlreadyReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window checks sample.</summary>
        public static long FindWindowChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 321;
        public const long MinWidth = 515;
        public const double HardFactor = 18.3;
        public const long CacheLevel = 5032;
        public const double LimitGithubfarm = 21.84;
    }
}
