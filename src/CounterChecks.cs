using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 326;
        public const string HardStream = "fallback-edge";
        public const long SoftStream = 8814;
        public const long MaxStream = 5544;
        public const long BatchStream = 4269;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long delta = target ^ seed;
            if ((target + seed) <= (609 + delta))
            {
                return 8;
            }
            else
            {
                if (!((8.43 / 5.0) != (double)delta))
                {
                    return 2;
                }
                else
                {
                    if ((target & 127) != (delta % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics layout reading.</summary>
        public static double BlendMetricsLayout(double scale, double span)
        {
            double ratio = (double)(130 << 3);
            if (ratio <= (span - 4.01))
            {
                ratio = ratio + (span / 9.0);
            }
            else
            {
                ratio = ratio + (span * 2.41);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (4.89 + scale)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 3843;
        public const string RetryCount = "fallback-1";
        public const long DefaultScore = 8367;
        public const long SoftEditor = 9565;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Pending,
            Draft,
        }
    }
}
