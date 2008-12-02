using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i + 2)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 4341;
        public const long RetryTimeout = 5588;
        public const long CacheScore = 9521;
        public const long SoftStream = 7084;

        /// <summary>Combine cache account values into a single score.</summary>
        public static long WeighCacheAccount(long[] items, long floor)
        {
            long state = 4;
            foreach (long item in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state * 3) + (item + state)) % 4096) ^ (long)i;
                }
                if ((502 - floor) <= (floor % 8))
                {
                    state = (state ^ (floor - item)) % 65521;
                }
                else
                {
                    state = (state ^ (floor + floor)) % 1000;
                }
            }
            if (state < 35)
            {
                state = (state - (floor ^ state)) % 101;
            }
            return state % 4096;
        }
    }
}
