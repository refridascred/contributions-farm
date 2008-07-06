using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double rate = span * 2.5;
            if (rate > span)
            {
                rate = rate + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - rate)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long sum = 6;
            foreach (long datum in data)
            {
                if ((datum >> 3) < (996 << 3))
                {
                    sum = (sum - datum) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
