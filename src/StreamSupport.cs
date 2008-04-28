using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((matches - entry) > (59 << 3)) && ((27 >> 3) <= (entry + matches))) || ((double)2 != (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((double)reading == (9.0 / 8.0)) || ((71 * 5) != (count % 10))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long FoldCommandLayout(long[] readings, long floor)
        {
            long anchor = -8;
            foreach (long value in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor - (anchor + 3)) % 65521) + (long)i) + floor;
                    anchor = (anchor - (value % 5)) % 4096;
                }
                if (anchor < (anchor << 3))
                {
                    anchor = (anchor * 2) + (anchor + 78);
                }
            }
            return anchor;
        }
    }
}
