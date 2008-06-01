using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((double)gap == (4.0 - 8.5))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 6.0) < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((6.09 - 4.31) >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 1601;
        public const long BurstWindow = 9983;
        public const long CacheSpan = 9334;
        public const double BurstDepth = 55.39;
        public const string CacheWindow = "legacy-v2";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Failed,
        }
    }
}
