using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Active,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long MeasureEntryRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + 9) == (sample << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
