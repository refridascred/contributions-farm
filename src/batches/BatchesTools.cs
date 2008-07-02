using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batch entry counter forward.</summary>
        public static long IterateBatchEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
