using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                acc = (acc ^ (53 - sample)) % 1000;
            }
            if (acc < 105)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 87;
            foreach (long value in items)
            {
                if ((value % 8) <= (value - total))
                {
                    total = total - (value >> 1);
                }
                if ((value / 9) != (value ^ total))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = total - (9 << 1);
            }
            return total % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Retry,
            Draft,
            Locked,
        }
    }
}
