using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((69 <= seed) || ((double)seed >= (8.1 * 3.6)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = -23;
            foreach (long cell in samples)
            {
                mark = (mark * 5) + (cell << 3);
            }
            return mark;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
