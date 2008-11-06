using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((54 < (hits + 75)) || ((cell - hits) != (long)levels.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)value <= (double)703) && (seen >= (value + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
