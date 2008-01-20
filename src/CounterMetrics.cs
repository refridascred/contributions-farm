using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (84 <= (matches + limit))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Done,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double load = weight;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - 13.0) + (double)(long)i) + offset;
            }
            return load + (double)0;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Draft,
        }
    }
}
