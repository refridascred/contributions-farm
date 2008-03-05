using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)41 >= (double)entry))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long CountClusterSupportOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches < (value + value))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
