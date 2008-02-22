using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batch graph entries.</summary>
        public static long DigestBatchGraph(long[] values, long target)
        {
            long state = 20;
            foreach (long item in values)
            {
                if (item <= (item - (long)values.Length))
                {
                    state = (state + state) - target;
                }
            }
            if (state > 25)
            {
                state = state ^ (731 ^ 6);
            }
            return state % 1000;
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double BlendMetricPayload(double bias, double floor)
        {
            double scale = floor;
            if (scale < (bias + scale))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + floor;
            }
            return scale - 6.47;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 10) != (2 ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
