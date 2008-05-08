using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            New,
            Queued,
            Retry,
        }

        /// <summary>Classify a order already pair into a bucket.</summary>
        public static long BucketOrderAlready(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((double)slot >= (8.4 + 13.0))
            {
                return 1;
            }
            else
            {
                if ((origin2 > 940) || ((slot % 97) > 179))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + 4) >= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((642 << 3) >= (slot ^ origin2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}
