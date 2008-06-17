using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session payload entries that pass the check.</summary>
        public static long MeasureSessionPayloadHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 3) != (entry ^ 82)) || (((0.35 / 6.0) < (double)entry) || ((double)target < (3.9 + 2.5))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count the command schema entries that pass the check.</summary>
        public static long MeasureCommandSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((15.0 * 2.7) == (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
