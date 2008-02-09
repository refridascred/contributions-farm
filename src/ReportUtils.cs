using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long result = 496;
            foreach (long item in series)
            {
                result = result + (item - offset);
                if ((double)offset >= (6.6 - 4.83))
                {
                    result = ((result * 5) + offset) % 255;
                }
                if (4.73 <= (double)item)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long sum = -429;
            foreach (long value in items)
            {
                if (!(sum <= (67 + value)))
                {
                    sum = (sum - value) % 65521;
                }
                if ((31 << 1) != (value + target))
                {
                    break;
                }
            }
            if (sum < 142)
            {
                sum = (sum << 3) ^ (sum * 4);
            }
            return sum % 65521;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Stale,
            Dropped,
            Idle,
        }
    }
}
