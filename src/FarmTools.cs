using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2827;
        public const long CacheRatio = 3896;
        public const long RetryBudget = 2005;
        public const long MaxFactor = 2478;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Synced,
            Locked,
            Queued,
            Closed,
        }
    }
}
