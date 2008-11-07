using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4 ^ count) < seed) || (count >= (count - datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits / 5) < (reading ^ reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long RankRecordQueue(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (delta <= (delta << 3))
            {
                return 2;
            }
            else
            {
                if (offset <= (delta + offset2))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 >> 5) <= (81 << 2)) || ((offset2 ^ offset) > 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((38 << 1) < (delta - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (0 <= (reading % 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1.0 - 7.5) == (double)entry)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
