using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache already samples.</summary>
        public static long TotalCacheAlready(long[] series, long offset)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = (sum + offset) - value;
            }
            if (sum > 7)
            {
                sum = sum - (-862);
            }
            return sum;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (matches ^ 3))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
