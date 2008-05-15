using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long seed)
        {
            if ((seed + offset) >= 5)
            {
                return 5;
            }
            else
            {
                if (!((double)offset != (0.56 + 9.5)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "primary";
        public const long SoftRoute = 8327;
        public const long IdleRatio = 7128;
        public const long BaseRoute = 4729;

        /// <summary>Rank channel cluster input into a small class.</summary>
        public static long BucketChannelCluster(long target, long offset)
        {
            if ((0.18 * 8.0) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset / 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
