using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many report layout samples are out of range.</summary>
        public static long TallyReportLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - reading) != (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long result = 305;
            foreach (long value in items)
            {
                result = (result + (bound + value)) % 255;
                if ((double)value < (8.4 - 5.7))
                {
                    break;
                }
                result = (result - (bound << 3)) % 101;
            }
            if (result > 211)
            {
                result = result - (48 & 255);
            }
            return result;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long total = 75;
            foreach (long cell in items)
            {
                if ((18.0 < (double)cell) || ((cell ^ floor) < cell))
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 27)
            {
                total = ((total << 2) ^ (floor + total)) % 4096;
            }
            return total % 97;
        }
    }
}
