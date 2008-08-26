using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ item) - target;
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 2402;
        public const long LimitProfile = 5303;
        public const long BatchSpan = 3118;
        public const long LimitWidth = 4260;
        public const string BatchInterval = "latest-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)tally == (3.5 / 3.0)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Draft,
            Paused,
            Retry,
            New,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= (sample ^ 62))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
