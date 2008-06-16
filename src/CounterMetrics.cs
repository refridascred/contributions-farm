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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
