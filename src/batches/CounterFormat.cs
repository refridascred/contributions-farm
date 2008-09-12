using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                state = (((state * 2) + (-5)) % 97) ^ sample;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 8632;
        public const string CacheLayout = "cached-v2";
        public const long RetryInterval = 2906;
    }
}
