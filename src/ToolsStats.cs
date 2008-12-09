using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)(long)i) - scale;
            }
            return rate + floor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((double)item <= (8.44 + 1.0)) || ((tally >> 5) <= (0 - item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)entry != (10.0 * 10.0)) && ((3.22 - 9.24) >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseInterval = "standard-edge";
        public const long BurstToken = 2026;
        public const long BatchRatio = 4441;
        public const long LimitToken = 4586;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long limit)
        {
            long total = 5;
            foreach (long datum in items)
            {
                total = (total * 5) + total;
                if (total > (total * 2))
                {
                    total = (total + (limit + datum)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
