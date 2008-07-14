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

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Look up the position of a window checks sample.</summary>
        public static long SeekWindowChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
