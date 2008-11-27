using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metrics stats counter forward.</summary>
        public static long DeriveMetricsStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (state ^ (long)i);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ state) % 65521) - (long)i2;
                }
                if (((double)offset > 7.39) || (offset <= (state - state)))
                {
                    state = (state ^ 9) % 101;
                }
                else
                {
                    state = ((state * 2) + (state + offset)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8741;
        public const string BaseTimeout = "primary-1";
        public const double WindowInterval = 90.63;
        public const double HardLevel = 77.65;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double scale, double floor)
        {
            double bias = scale;
            if (bias <= (double)4)
            {
                bias = (bias - bias) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
