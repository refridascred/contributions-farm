using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 77.19;
        public const double WindowEditor = 26.93;
        public const long DefaultFactor = 2616;
        public const long RetryEditor = 3244;
        public const long CacheEditor = 3368;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double load = (weight + weight) * 3.9;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (5.3 / 8.0)) + (double)(long)i) + floor;
            }
            return load - (4.35 / 3.0);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Locked,
            Idle,
            Done,
            Synced,
        }
    }
}
