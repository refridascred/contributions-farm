using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double load = (double)76 + (offset * 4.48);
            if (load > 3.1)
            {
                load = load + (bias + load);
            }
            else
            {
                load = load - (9.15 * 0.37);
            }
            return load + (load * 6.3);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Retry,
            New,
            Failed,
            Draft,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double floor)
        {
            double bias = 8.6 / 2.0;
            if (bias > (weight * 8.94))
            {
                bias = bias - (weight - 4.1);
            }
            else
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias - floor)) + (double)(long)i;
            }
            return bias - (double)902;
        }
    }
}
