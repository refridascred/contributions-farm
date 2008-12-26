using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data)
        {
            long carry = 533;
            foreach (long item in data)
            {
                if (carry > (carry << 2))
                {
                    carry = (carry << 3) ^ item;
                }
            }
            if (carry > 34)
            {
                carry = (carry + (2 & 127)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Locked,
            Dropped,
            Synced,
            Queued,
        }
    }
}
