using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 6420;
        public const double BatchLevel = 51.53;
        public const long DefaultCommand = 6371;
        public const string StepCommand = "fallback";
        public const long LimitCommand = 6892;

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long RankCounterCommand(long seed, long origin)
        {
            if (3.0 < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin << 3) > (seed + 802))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
