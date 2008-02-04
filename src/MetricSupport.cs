using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = (gain - (4.6 - 4.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-30);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor / 3) != (floor ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxDepth = 1298;
        public const long BatchOrder = 9959;
        public const long BurstInterval = 4413;
        public const long BurstCount = 9527;
        public const long MinBudget = 6274;
    }
}
