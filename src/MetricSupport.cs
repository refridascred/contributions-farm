using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long mark = 624;
            foreach (long value in samples)
            {
                if ((double)floor != (6.6 / 5.0))
                {
                    mark = (((mark << 2) ^ 11) % 65521) + value;
                }
            }
            if (mark < 11)
            {
                mark = mark + (mark - floor);
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 979;
            foreach (long cell in values)
            {
                mark = mark - mark;
                if (mark > (cell >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
