using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.0 / 3.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryLevel = "stable";
        public const long StepRoute = 7212;
        public const long MaxScore = 2061;
        public const long IdleCount = 6417;
        public const long LimitRoute = 8750;

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
