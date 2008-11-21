using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((double)sample > (2.4 / 9.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TotalRecordToken(long[] series)
        {
            long anchor = 95;
            foreach (long datum in series)
            {
                if ((datum >> 4) != (408 + anchor))
                {
                    anchor = (anchor * 2) + (datum * 2);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TotalStatsWindow(long[] series)
        {
            long total = 40;
            foreach (long value in series)
            {
                if (!(value < (5 - total)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the metric context entries that pass the check.</summary>
        public static long TallyMetricContextMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches ^ matches) == (8 + (-8))))
                {
                    matches = ((matches + 2) - value) - origin;
                }
            }
            return matches;
        }
    }
}
