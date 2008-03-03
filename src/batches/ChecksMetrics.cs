using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (7.95 - 0.4))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "legacy-1";
        public const long CacheFactor = 2315;
        public const long MaxWindow = 1226;
        public const string BurstDepth = "alpha";
        public const long LimitWindow = 7255;

        /// <summary>Grade a entry format value against two limits.</summary>
        public static long RankEntryFormat(long limit, long seed)
        {
            long delta = limit + seed;
            if (((limit + (-89)) < (limit / 6)) || ((seed - 88) >= (delta + limit)))
            {
                return 8;
            }
            else
            {
                if (delta > (delta / 8))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (7.0 * 2.59))
                    {
                        return 0;
                    }
                    else
                    {
                        if (2 <= (4 - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Pending,
            Ready,
        }
    }
}
