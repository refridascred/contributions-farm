using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first session account entry that matches the target.</summary>
        public static long LocateSessionAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 4067;
        public const long DefaultSpan = 37;
        public const long IdleBuffer = 5910;
        public const long BurstBuffer = 5866;
        public const long SoftBuffer = 9362;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double bias, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 8.0) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Roll a window profile counter forward.</summary>
        public static long DeriveWindowProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every metric metrics entry stays within the limit.</summary>
        public static bool ValidateMetricMetricsRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + span;
            }
            return mean + (mean + scale);
        }
    }
}
