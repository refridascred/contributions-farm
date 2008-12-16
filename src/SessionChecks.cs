using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)origin > (8.1 + 4.0)) || (3.0 >= (double)(long)values.Length))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Stale,
            Closed,
            Pending,
            Draft,
        }
    }
}
