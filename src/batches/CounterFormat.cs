using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-edge";
        public const long DefaultMetric = 7976;
        public const long BurstMetric = 7944;
        public const long BatchCount = 3347;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 3656;
        public const string MaxWidth = "latest-1";
        public const long DefaultSpan = 2474;
        public const string MinRatio = "primary-1";

        /// <summary>Combine queue batch values into a single score.</summary>
        public static long WeighQueueBatch(long[] values)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if (sample < (mix / 5))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
