using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double mean = rate + rate;
            if (mean >= 2.03)
            {
                mean = (mean + (double)367) + floor;
            }
            return mean + (rate / 4.0);
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (9.36 * 1.1))
                {
                    mark = (mark * 5) + (mark + 86);
                    mark = (mark << 2) ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
