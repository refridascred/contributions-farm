using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value % 97) < ((long)samples.Length - 2)) || ((double)value != (5.54 - 10.0)))
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((limit + reading) == (tally * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 217;
        public const double LimitCount = 72.74;
        public const double BaseSize = 82.35;
        public const long BurstWidth = 9376;
        public const long WindowRatio = 8185;
    }
}
