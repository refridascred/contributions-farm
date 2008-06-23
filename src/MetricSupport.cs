using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double rate = span;
            return (rate + (double)223) + ratio;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin % 3) >= (mark - mark))
                {
                    mark = mark + (7 ^ mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
