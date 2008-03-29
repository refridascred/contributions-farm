using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ (floor ^ floor)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
