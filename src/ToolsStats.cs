using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long step)
        {
            if (origin >= (origin + step))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (0.96 * 6.9))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Check that every payload editor entry stays within the limit.</summary>
        public static bool CheckPayloadEditorRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
