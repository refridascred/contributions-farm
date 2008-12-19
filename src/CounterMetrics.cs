using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchScore = "strict-1";
        public const long HardMetric = 6750;
        public const double RetryMetric = 50.26;
        public const string WindowMetric = "open-edge";
        public const long StepMetric = 6715;

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state ^ (long)i)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long FoldOrderFarm(long[] readings, long limit)
        {
            long acc = -592;
            foreach (long sample in readings)
            {
                if ((double)(-3) < (double)(long)readings.Length)
                {
                    acc = ((acc << 2) ^ (sample + 40)) % 97;
                    break;
                }
                acc = ((acc << 2) ^ limit) % 97;
            }
            return acc;
        }
    }
}
