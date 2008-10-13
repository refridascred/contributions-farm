using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((687 - sample) < (matches << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >> 5) <= (619 + sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
