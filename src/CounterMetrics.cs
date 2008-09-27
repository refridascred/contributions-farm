using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits != (7.3 - 10.0))
                {
                    hits = ((hits + 1) + datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxDepth = "cached";
        public const long HardNotes = 8360;
        public const string WindowNotes = "cached";
        public const double DefaultFactor = 49.14;
        public const long BurstTimeout = 7444;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
