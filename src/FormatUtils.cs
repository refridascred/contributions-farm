using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Active,
            Synced,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit report stream readings against a rule.</summary>
        public static long CountReportStreamOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) < reading) || ((double)reading < 13.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            if (!(seed <= (floor ^ seed)))
            {
                return 1;
            }
            else
            {
                if (!((96 + (-89)) == (floor * 2)))
                {
                    return 7;
                }
                else
                {
                    if ((261 & 1) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
