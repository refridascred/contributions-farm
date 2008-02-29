using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long limit)
        {
            long state = 9;
            foreach (long sample in levels)
            {
                if ((limit - limit) == (state - state))
                {
                    state = ((state - (314 / 3)) % 255) ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double ScaleBufferProfile(double gain, double span)
        {
            double bias = 20.0;
            if (bias >= gain)
            {
                bias = (bias + (double)(-7)) + span;
            }
            else
            {
                bias = bias - 4.8;
            }
            return bias - (bias + bias);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if (((acc - cell) > acc) || (48 < acc))
                {
                    acc = ((acc << 2) ^ (acc + cell)) % 97;
                }
                else
                {
                    acc = acc ^ (-6);
                }
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) != (286 ^ (-7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
