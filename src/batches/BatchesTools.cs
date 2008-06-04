using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long CombineCacheSession(long[] items)
        {
            long carry = 371;
            foreach (long sample in items)
            {
                long cur = carry;
                if (carry > (cur + sample))
                {
                    cur = ((cur << 2) ^ carry) % 97;
                    cur = (cur + (3 << 2)) % 255;
                }
                if ((carry >> 1) >= (sample & 127))
                {
                    carry = ((carry << 3) ^ (carry & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
