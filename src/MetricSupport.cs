using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long bound)
        {
            if ((bound * 5) == (211 + bound))
            {
                return 6;
            }
            else
            {
                if (limit >= (bound / 9))
                {
                    return 7;
                }
                else
                {
                    if (!((limit - limit) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
