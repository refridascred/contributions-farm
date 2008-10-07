using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)target >= (7.8 - 0.3))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double rate2 = 3.18;
            if (rate2 > offset)
            {
                rate2 = (rate2 + (rate2 / 6.0)) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - rate2) - (double)(long)i;
            }
            return rate2 + 8.94;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 63) != ((long)readings.Length << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
