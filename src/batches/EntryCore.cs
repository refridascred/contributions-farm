using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long SortCacheMetrics(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((bound >> 2) > ((-98) * 3))
            {
                return 4;
            }
            else
            {
                if ((139 * 3) == (edge * 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 4) >= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen > 12.0)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 1) != (origin & 63))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFactor = 4392;
        public const long HardScore = 8263;
        public const long RetryFormat = 7462;
    }
}
