using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9181;
        public const string HardSize = "latest-1";
        public const long IdleFilter = 8568;
        public const string HardLevel = "fallback-v2";
        public const string CacheSpan = "local-1";

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((0 / 2) > (item - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels, long origin)
        {
            long mark = 38;
            foreach (long reading in levels)
            {
                mark = ((mark + (mark + origin)) % 101) + reading;
            }
            return mark;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
