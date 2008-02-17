using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryFactor = 28.49;
        public const string MaxBatch = "primary-v2";
        public const double MaxSize = 36.72;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((0.3 - 8.0) > (double)floor) || ((double)cell > 0.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
