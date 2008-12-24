using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a report already reading by value.</summary>
        public static long LookupReportAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
