using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank format batches input into a small class.</summary>
        public static long RankFormatBatches(long seed, long floor)
        {
            long next = seed - floor;
            if ((floor - floor) == (seed + floor))
            {
                return 6;
            }
            else
            {
                if ((next >= (floor << 1)) && ((double)next <= 8.8))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mix = 11;
            foreach (long item in data)
            {
                if (129 >= offset)
                {
                    mix = mix + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 108;
        public const long BatchMetrics = 7008;
        public const long MinInterval = 3462;
    }
}
