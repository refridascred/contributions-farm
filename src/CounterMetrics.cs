using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long CountAlreadyMetricsGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (4.75 >= (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Done,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double offset)
        {
            double gain = offset;
            if (gain >= (double)16)
            {
                gain = gain - (bias - bias);
            }
            return gain - bias;
        }
    }
}
