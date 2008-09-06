using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9562;
        public const double MaxCommand = 89.16;
        public const double StepScore = 70.23;
        public const long LimitCommand = 3663;

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long MeasureNotesEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally + entry) <= (tally << 3)) || !(entry > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((5.3 * 14.0) == (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
