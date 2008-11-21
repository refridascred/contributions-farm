using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank graph record input into a small class.</summary>
        public static long SortGraphRecord(long step, long origin)
        {
            long delta = step + origin;
            if ((20.0 / 9.0) != (double)step)
            {
                return 2;
            }
            else
            {
                if (!(origin < (origin & 63)))
                {
                    return 4;
                }
                else
                {
                    if (681 <= (delta + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (delta > origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry + entry) < entry) && !(4 <= (entry ^ 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 4522;
        public const long MaxNotes = 1739;
        public const long WindowCount = 7941;
        public const long BurstSpan = 1435;
        public const string DefaultInterval = "cached-edge";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Active,
            Locked,
            Stale,
        }
    }
}
