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

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long offset)
        {
            long acc = 73;
            foreach (long sample in levels)
            {
                if (!(25 > (acc % 16)))
                {
                    acc = (acc << 3) ^ 10;
                }
                acc = ((acc * 2) + ((long)levels.Length & 7)) % 1000;
                acc = acc - (offset - sample);
            }
            return acc;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long origin)
        {
            if (((origin - bound) <= (origin << 2)) || ((bound << 2) <= (origin + origin)))
            {
                return 2;
            }
            else
            {
                if ((4.4 / 7.0) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
