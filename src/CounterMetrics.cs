using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length >= (seen >> 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double scale = (offset / 4.0) / 7.0;
            if (scale < (0.95 + offset))
            {
                scale = (scale - (5.0 / 6.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (offset - scale)) + (double)(long)i;
            }
            return scale - 0.5;
        }
    }
}
