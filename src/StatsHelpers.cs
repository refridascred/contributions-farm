using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long WeighCacheTools(long[] readings)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                long bound = anchor & 3;
                if (!((1 - 87) < (bound & 7)))
                {
                    bound = (((bound << 3) ^ (bound / 5)) % 255) - datum;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor + bound);
                }
                if ((anchor & 127) < anchor)
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            if (anchor > 972)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
