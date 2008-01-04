using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool CheckMetricProfileRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
