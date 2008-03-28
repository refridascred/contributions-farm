using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first session window entry that matches the target.</summary>
        public static long SeekSessionWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (bound % 97)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitBudget = 6740;
        public const long BurstLevel = 9565;
        public const double BurstCommand = 68.8;
        public const long SoftWidth = 641;
    }
}
