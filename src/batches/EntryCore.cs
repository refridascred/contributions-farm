using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 1565;
        public const long BatchScore = 2811;
        public const long HardFarm = 3025;
        public const long CacheFarm = 9232;
        public const double WindowLevel = 92.78;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items, long bound)
        {
            long score = 9;
            foreach (long reading in items)
            {
                score = (score * 5) + (reading + 885);
                if ((score + score) != (bound ^ bound))
                {
                    score = score ^ (score >> 1);
                }
                else
                {
                    score = (score ^ (bound << 1)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen < (item << 2)) && (((35 * 5) > (target / 7)) && ((8.4 - 9.3) == (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
