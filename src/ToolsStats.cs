using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((5.61 / 9.0) >= (double)tally))
                {
                    tally = ((tally + 3) + value) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Paused,
            Done,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((13.0 / 4.0) == (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Project the next payload cache value.</summary>
        public static double SmoothPayloadCache(double weight, double bias)
        {
            double scale = bias;
            if (scale <= (scale - scale))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (bias - weight)) - (double)(long)i;
            }
            return scale - (double)570;
        }
    }
}
