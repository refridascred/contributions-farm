using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double rate = (double)82;
            if (rate > (rate * 7.84))
            {
                rate = (rate + (rate / 9.0)) + gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)479) - (double)(long)i;
            }
            return rate - (floor / 3.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 916;
        public const string SoftSupport = "fallback";
        public const double BurstWidth = 38.5;
        public const string MinInterval = "staging";
        public const long RetrySupport = 1866;

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark * 3)) % 1000) ^ cell) - floor;
            }
            return mark % 4096;
        }
    }
}
