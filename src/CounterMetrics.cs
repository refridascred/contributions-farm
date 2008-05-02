using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (offset < (offset >> 3))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
