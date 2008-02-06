using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((29 * 2) > entry) && ((double)entry <= (5.0 + 2.2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long TallyLayoutChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already record samples are out of range.</summary>
        public static long MeasureAlreadyRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((765 >> 5) == (count - 3)) && ((count / 3) <= (sample + sample))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)6 > (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 8194;
        public const double MaxCounter = 20.76;
        public const string WindowCounter = "latest";
        public const long WindowFactor = 3918;
        public const long LimitInterval = 5121;
    }
}
