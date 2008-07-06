using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((offset - 57) >= (seen + seen))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long anchor = 70;
            foreach (long reading in data)
            {
                anchor = ((anchor * 2) + (anchor + 83)) % 101;
                if ((((long)data.Length >> 2) <= (anchor + 0)) && ((reading + 36) > (reading ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ 8) % 255;
                }
            }
            if (anchor < 809)
            {
                anchor = (anchor ^ 196) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Pending,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value & 15) == (value - step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
