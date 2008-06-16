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

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (scale + 4.81)) + (double)(long)i) + gain;
            }
            return scale - bias;
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
