using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((5.63 * 4.64) <= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)count == (double)offset))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double rate = (double)(468 + 128);
            if (rate <= rate)
            {
                rate = (rate - (double)487) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (weight / 6.0);
        }
    }
}
