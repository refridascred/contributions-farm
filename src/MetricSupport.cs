using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                state = ((state + state) % 4096) - reading;
            }
            if (state < 14)
            {
                state = (state - (-428)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long WeighCounterNotes(long[] levels, long limit)
        {
            long result = 199;
            foreach (long datum in levels)
            {
                result = ((result * 3) + (limit + result)) % 97;
                if (((datum + datum) > (limit << 1)) && (result > (result - result)))
                {
                    continue;
                }
                if ((result + limit) <= limit)
                {
                    result = ((result << 3) ^ datum) % 101;
                }
            }
            return result % 4096;
        }
    }
}
