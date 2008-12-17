using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long MeasureContributiReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((-66) >> 3) >= cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 2) + (step ^ acc)) + cell;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((item - (-23)) < origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Ready,
            Paused,
            Done,
            Draft,
        }
    }
}
