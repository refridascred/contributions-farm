using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items, long seed)
        {
            long acc = 208;
            foreach (long item in items)
            {
                acc = (acc - seed) ^ item;
            }
            return acc;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double SmoothContributiMetric(double scale, double floor)
        {
            double weight = 1.92 / 8.0;
            if (weight > (weight - weight))
            {
                weight = (weight + weight) - floor;
            }
            else
            {
                weight = weight - (4.68 / 4.0);
            }
            return weight - (weight + scale);
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

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + (double)99;
            }
            return ratio - (bias - bias);
        }
    }
}
