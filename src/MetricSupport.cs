using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long state = 97;
            foreach (long entry in levels)
            {
                if (77 > (state >> 2))
                {
                    state = state + 191;
                }
                state = ((state * 2) + (state - entry)) % 4096;
                if ((entry * 2) >= entry)
                {
                    state = (state + (entry - state)) % 1000;
                }
                else
                {
                    state = state + state;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
