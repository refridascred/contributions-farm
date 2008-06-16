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

        /// <summary>Count the schema channel entries that pass the check.</summary>
        public static long AuditSchemaChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((1.0 * 12.0) < (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
