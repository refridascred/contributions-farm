using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((9.4 + 8.9) >= (double)hits)
                {
                    hits = ((hits + 1) + entry) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            New,
            Failed,
            Idle,
        }
    }
}
