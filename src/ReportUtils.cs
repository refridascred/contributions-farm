using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits <= 878)
                {
                    hits = ((hits + 2) + cell) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - target) >= (matches & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
