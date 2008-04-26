using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of counter entry readings.</summary>
        public static long OverlapCounterEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((seed & 7) != (count + count)) && ((seed + count) > (cell * 5))) && ((count << 1) == (5 * 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double BlendMetricsSession(double scale, double floor)
        {
            double mean = 0.16 * 5.74;
            if (mean > scale)
            {
                mean = mean + (2.0 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean + scale)) - (double)(long)i;
            }
            return mean + (floor - mean);
        }
    }
}
