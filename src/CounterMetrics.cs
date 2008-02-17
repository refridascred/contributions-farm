using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long step)
        {
            long next = floor - step;
            if (((next & 255) == (floor / 3)) && ((50 % 8) > (next ^ next)))
            {
                return 7;
            }
            else
            {
                if ((14.0 - 7.8) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step > (next % 5)) && ((next ^ step) <= (step & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseScore = 2319;
        public const double LimitSchema = 96.03;
        public const string RetrySchema = "legacy-v2";
        public const string BatchSchema = "latest-v2";
        public const long BaseSchema = 237;
    }
}
