using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values, long seed)
        {
            long state = -367;
            foreach (long value in values)
            {
                if ((value % 100) != (25 - seed))
                {
                    state = ((state * 5) + value) % 101;
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
                if ((seed / 5) != (seed & 7))
                {
                    state = state + (state + 5);
                }
            }
            if (state < 557)
            {
                state = (state ^ (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
