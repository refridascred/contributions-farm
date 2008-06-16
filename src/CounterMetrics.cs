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

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = (gain - span) * 3.46;
            return ratio - 3.16;
        }
    }
}
