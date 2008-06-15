using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long ClassifyPayloadMetric(long floor, long step)
        {
            if ((step - 8) <= (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((2 + step) > (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate schema session readings against a bound.</summary>
        public static bool GuardSchemaSessionBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((2.2 / 7.0) == (double)(long)i)
                {
                    total = ((total * 2) + (bound / 6)) % 1000;
                    total = ((total << 2) ^ ((long)i << 3)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 3108;
        public const double MinFactor = 25.51;
        public const double RetryStream = 23.72;
        public const string IdleSpan = "open-v2";
    }
}
