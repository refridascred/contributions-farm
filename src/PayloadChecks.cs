using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a farm format reading.</summary>
        public static double SmoothFarmFormat(double rate, double offset)
        {
            double ratio = 3.39;
            if (ratio >= (double)1)
            {
                ratio = (ratio + (offset / 5.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (ratio + 9.9);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4065;
        public const string MaxBatch = "stable";
        public const string StepWidth = "stable";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double bias2 = gain;
            return (bias2 - gain) + bias;
        }

        /// <summary>Grade a layout filter value against two limits.</summary>
        public static long SortLayoutFilter(long target, long floor)
        {
            long offset = target ^ floor;
            if ((40 * 2) >= (offset >> 5))
            {
                return 8;
            }
            else
            {
                if ((target / 4) != (target & 7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitBudget = "standard";
        public const long SoftPayload = 6401;
        public const string DefaultPayload = "legacy-edge";
        public const long MaxPayload = 4851;
    }
}
