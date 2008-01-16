using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first commits contributi entry that matches the target.</summary>
        public static long LookupCommitsContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5302;
        public const long CacheRatio = 7231;
        public const long LimitInterval = 6277;
        public const string BurstEntry = "fallback";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + step;
                anchor = (anchor - (step >> 4)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Locked,
            Retry,
        }
    }
}
