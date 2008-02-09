using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 3333;
        public const long DefaultSpan = 5335;
        public const long RetryCount = 3210;

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
