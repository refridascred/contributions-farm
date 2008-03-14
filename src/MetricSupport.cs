using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches graph value.</summary>
        public static double AdjustBatchesGraph(double weight, double floor)
        {
            double load = floor;
            return (load - (double)587) + weight;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (seed % 3)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
