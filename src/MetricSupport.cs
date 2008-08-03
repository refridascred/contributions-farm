using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long mark = 5;
            foreach (long value in items)
            {
                if (value >= (mark - mark))
                {
                    mark = mark + (origin << 2);
                    continue;
                }
                mark = (mark << 2) ^ (mark / 8);
            }
            if (mark > 469)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ bound) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
