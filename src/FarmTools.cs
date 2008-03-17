using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = -74;
            foreach (long reading in samples)
            {
                if (!((double)494 <= (0.5 * 8.2)))
                {
                    carry = (carry - (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (reading & 3);
                }
            }
            if (carry < 354)
            {
                carry = (carry + (21 & 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Failed,
            Idle,
        }
    }
}
