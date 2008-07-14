using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 259;
        public const long HardInterval = 4031;
        public const string CacheGraph = "fallback";
        public const double CacheRatio = 58.6;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mix = 546;
            foreach (long item in readings)
            {
                if (!(((-9) / 9) < (item >> 2)))
                {
                    mix = (mix + (mix - 903)) % 4096;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double ratio = 6.25;
            if (ratio > (bias - ratio))
            {
                ratio = (ratio + (bias - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long state = 14;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ state) % 255) ^ reading) - floor;
            }
            if (state < 64)
            {
                state = (state ^ 23) % 255;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultTimeout = 1184;
        public const long DefaultContext = 660;
        public const double SoftContext = 77.53;
    }
}
