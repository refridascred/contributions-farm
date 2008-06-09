using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long RollClusterWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - ((long)i / 5);
                anchor = ((anchor * 2) + (floor & 255)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = ((total - sample) % 255) - target;
                if ((long)items.Length < sample)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
