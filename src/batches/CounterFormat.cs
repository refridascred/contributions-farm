using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double drift = 13.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - bias) + (double)(long)i) - gain;
            }
            return drift - (bias - bias);
        }

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long CountChecksReportGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((offset % 97) < (sample >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 83.58;
        public const double CacheAlready = 39.27;
        public const long MinAlready = 6537;
    }
}
