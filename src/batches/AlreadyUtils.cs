using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
