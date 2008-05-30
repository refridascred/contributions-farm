using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches + reading) < reading))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool GuardToolsContributiRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= (cell / 8))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
