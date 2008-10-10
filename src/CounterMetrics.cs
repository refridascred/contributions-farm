using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long ClassifyBatchesRoute(long target, long limit)
        {
            long lane = target - limit;
            if ((double)lane == (0.28 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = -349;
            foreach (long datum in readings)
            {
                if ((double)104 >= (double)mix)
                {
                    mix = (mix ^ (mix * 5)) % 1000;
                }
                mix = (mix ^ (3 + datum)) % 4096;
                if ((17.0 + 1.9) != (double)mix)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardDepth = "fallback-v2";
        public const long BaseEntry = 9525;
        public const long BatchWidth = 4102;
        public const long BurstEntry = 5445;
        public const long LimitEntry = 6729;
    }
}
