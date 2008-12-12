using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Closed,
            Queued,
            Done,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if ((6.1 <= (double)offset) || (bound >= (bound / 6)))
            {
                return 5;
            }
            else
            {
                if ((bound >> 2) != (offset + bound))
                {
                    return 2;
                }
                else
                {
                    if ((9.9 * 9.1) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits == (double)limit)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((50 + matches) >= (9 + matches))
                {
                    matches = ((matches + 2) ^ sample) + limit;
                }
            }
            return matches;
        }
    }
}
