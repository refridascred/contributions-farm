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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((target < (step & 3)) && ((target ^ step) > 43))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (1.2 - 11.0)) || (5.07 <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (step ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
