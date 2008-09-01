using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((offset - count) < (count << 3)) || ((offset + count) != (12 - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
