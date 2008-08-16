using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long target)
        {
            long state = 54;
            foreach (long sample in values)
            {
                if (((double)target < (8.0 + 4.42)) || ((target - state) <= (target + sample)))
                {
                    state = ((state * 5) + (572 + state)) % 97;
                }
                if ((sample ^ 3) < (target >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "cached-1";
        public const long BatchDepth = 7477;
        public const long LimitLevel = 3767;
        public const long IdleRoute = 1891;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (reading * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
