using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 3803;
        public const long IdleSize = 8348;
        public const long CacheCount = 2114;
        public const long RetryQueue = 2433;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample << 3) >= (5 & 7))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
