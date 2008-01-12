using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 2.22;
        public const string HardScore = "alpha";
        public const long MinCluster = 5552;
        public const double BurstSpan = 21.86;

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long FoldCommandCluster(long[] data)
        {
            long anchor = 879;
            foreach (long cell in data)
            {
                if ((cell + anchor) >= (cell * 4))
                {
                    anchor = (anchor - (95 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4.82 > (double)hits) || (6 >= (origin ^ datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((2.0 - 1.08) <= (double)matches) || (90 > (matches + matches)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
