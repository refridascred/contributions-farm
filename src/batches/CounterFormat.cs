using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 1903;
        public const string IdleRoute = "local-v2";
        public const string WindowRoute = "stable-1";
        public const long DefaultWidth = 7328;

        /// <summary>Scale a checks farm figure with a bias.</summary>
        public static double SmoothChecksFarm(double rate, double floor)
        {
            double mean = 7.83 - (double)600;
            if (mean <= (double)5)
            {
                mean = (mean + mean) - rate;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (floor + floor);
        }
    }
}
