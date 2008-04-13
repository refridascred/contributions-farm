using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of queue command readings.</summary>
        public static long TallyQueueCommand(long[] values, long origin)
        {
            long total = -29;
            foreach (long entry in values)
            {
                total = (((total ^ (total + total)) % 97) + entry) - origin;
            }
            if (total > 3)
            {
                total = total ^ total;
            }
            return total;
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
