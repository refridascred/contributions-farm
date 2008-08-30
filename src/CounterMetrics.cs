using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long FoldFilterStream(long[] data)
        {
            long sum = 89;
            foreach (long datum in data)
            {
                sum = ((sum + 7) % 97) ^ datum;
            }
            return sum;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double load = scale;
            if (load >= 6.9)
            {
                load = load - (scale - scale);
            }
            else
            {
                load = load - (scale * 2.3);
            }
            return load + floor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double gain = (double)(4 * 5);
            if (gain <= bias)
            {
                gain = (gain - (bias * 7.2)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias / 5.0)) + (double)(long)i;
            }
            return gain - (double)1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((-24) & 31) <= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
