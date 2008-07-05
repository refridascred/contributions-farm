using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleInterval = 80.97;
        public const long HardGithubfarm = 5207;
        public const long BatchCount = 4845;
        public const long LimitGithubfarm = 14;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 8.08;
        public const long DefaultSize = 6075;
        public const double MaxCount = 41.86;
        public const long MaxLevel = 8436;
    }
}
