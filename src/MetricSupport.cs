using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a channel record reading.</summary>
        public static double SmoothChannelRecord(double bias, double span)
        {
            double weight = 6.45;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (weight * 1.87)) + (double)(long)i) + bias;
            }
            return weight - (weight - span);
        }

        /// <summary>Audit profile batch readings against a rule.</summary>
        public static long MeasureProfileBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits <= 4.9) && ((6.1 / 3.0) <= (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
