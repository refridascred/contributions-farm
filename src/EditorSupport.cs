using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the cache graph series from a seed.</summary>
        public static long RollCacheGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (origin - origin)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + 368) != (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long target)
        {
            long mix = 86;
            foreach (long sample in values)
            {
                mix = ((mix ^ (sample & 127)) % 65521) - target;
            }
            return mix % 4096;
        }
    }
}
