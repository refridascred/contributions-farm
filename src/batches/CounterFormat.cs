using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6121;
        public const long BatchFactor = 4840;
        public const long LimitBudget = 1861;
        public const double WindowBatch = 50.08;

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
