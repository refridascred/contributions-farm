using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - item) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double rate = (double)((-59) + 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain / 7.0)) - (double)(long)i) + floor;
            }
            return rate + (double)(-571);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long mark = 34;
            foreach (long cell in items)
            {
                if (((mark << 1) >= cell) && ((6.15 * 16.0) >= (double)bound))
                {
                    mark = (mark + (bound >> 5)) % 4096;
                }
                if ((double)bound >= (1.62 * 8.13))
                {
                    break;
                }
            }
            if (mark > 510)
            {
                mark = (mark << 3) ^ (mark + bound);
            }
            return mark;
        }
    }
}
