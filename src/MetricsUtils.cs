using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit route session readings against a rule.</summary>
        public static long TallyRouteSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item << 2) < (seen ^ item)) || ((double)seen < (5.8 + 0.55)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 73;
            foreach (long reading in levels)
            {
                if (reading >= (reading - acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc > 4)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 4096;
        }
    }
}
