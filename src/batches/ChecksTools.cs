using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleFactor = 22.89;
        public const long MinStream = 9136;
        public const double WindowStream = 63.04;
        public const double IdleStream = 43.64;
        public const long BatchFactor = 4282;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) != (reading / 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Synced,
            Queued,
        }
    }
}
