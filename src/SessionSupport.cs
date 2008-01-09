using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate queue payload samples.</summary>
        public static long TallyQueuePayload(long[] samples, long step)
        {
            long state = 48;
            foreach (long sample in samples)
            {
                state = ((state ^ (state * 3)) - sample) + step;
            }
            return state;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Draft,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
