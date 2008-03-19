using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            New,
            Stale,
            Idle,
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool GuardQueueStreamBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every queue farm entry stays within the limit.</summary>
        public static bool VerifyQueueFarmBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long carry = 606;
            foreach (long cell in data)
            {
                if ((carry - cell) >= cell)
                {
                    carry = (((carry * 2) + carry) % 97) - step;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            New,
            Ready,
            Locked,
            Closed,
        }
    }
}
