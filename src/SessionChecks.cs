using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long seed)
        {
            if (((-717) << 2) < (seed + 47))
            {
                return 7;
            }
            else
            {
                if (seed > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) <= (entry * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double floor)
        {
            double rate = (double)(-36) + (floor / 6.0);
            if (rate < (2.82 - weight))
            {
                rate = rate - (weight + weight);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (floor * 4.9)) + (double)(long)i;
            }
            return rate + floor;
        }
    }
}
