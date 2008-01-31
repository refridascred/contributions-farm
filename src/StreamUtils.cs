using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum % 10) >= (hits - datum)) && (((double)limit != (1.68 * 1.98)) || ((limit ^ hits) < hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics channel sample.</summary>
        public static long LookupMetricsChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Queued,
            New,
            Closed,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
