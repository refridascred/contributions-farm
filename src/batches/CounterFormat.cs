using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback-1";
        public const string SoftCounter = "alpha-v2";
        public const double RetryWidth = 24.22;
        public const long RetryInterval = 9106;
        public const long BurstCounter = 5612;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] items)
        {
            long mix = 874;
            foreach (long value in items)
            {
                if (!((value & 31) <= (306 << 3)))
                {
                    mix = mix + (mix - 364);
                    mix = mix + (value >> 4);
                }
                mix = (mix ^ (value - value)) % 97;
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
