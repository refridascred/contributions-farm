using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Failed,
            Retry,
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
