using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long WeighQueueMetrics(long[] items, long limit)
        {
            long total = 645;
            foreach (long datum in items)
            {
                total = ((total * 4) + (limit + 713)) - datum;
            }
            if (total > 545)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Count metric stats pairs that satisfy a relation.</summary>
        public static long PairMetricStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double BlendFilterOrder(double bias, double floor)
        {
            double gain = bias;
            if (gain <= floor)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 5.64;
        }
    }
}
