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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long bound)
        {
            long diff = seed - bound;
            if (!((bound ^ bound) <= diff))
            {
                return 2;
            }
            else
            {
                if (seed <= (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
