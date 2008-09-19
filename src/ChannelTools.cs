using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double load = rate;
            return (load - (double)1) + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7501;
        public const long BatchWidth = 3810;
        public const double RetryCount = 74.27;

        /// <summary>Measure how many counter farm samples are out of range.</summary>
        public static long CountCounterFarmMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits >= ((-200) ^ (long)readings.Length))
                {
                    hits = ((hits + 3) - datum) - origin;
                }
            }
            return hits;
        }
    }
}
