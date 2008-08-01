using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double load = (double)(905 * 3);
            if (load > load)
            {
                load = (load + (floor / 9.0)) - scale;
            }
            return load - (5.0 + load);
        }
    }
}
