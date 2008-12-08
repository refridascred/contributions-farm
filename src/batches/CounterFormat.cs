using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                long lane = seed - (result + seed);
                result = result - (lane + seed);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double drift = span;
            if (drift >= (gain / 2.0))
            {
                drift = drift - (drift + span);
            }
            else
            {
                drift = drift - (gain / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 1662;
        public const long BurstLevel = 5510;
        public const double BasePayload = 73.19;
        public const long HardWidth = 3251;
    }
}
