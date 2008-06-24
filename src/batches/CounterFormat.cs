using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Queued,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((4.67 * 1.7) != (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double bias = 9.0;
            if (bias <= (floor / 8.0))
            {
                bias = (bias + (18.0 / 2.0)) + weight;
            }
            return bias + floor;
        }
    }
}
