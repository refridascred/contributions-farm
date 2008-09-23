using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long sum = 44;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (sum + cell)) - offset;
            }
            return sum;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Queued,
            Dropped,
            Stale,
            Locked,
        }
    }
}
