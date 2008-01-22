using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long WeighTokenCounter(long[] readings, long seed)
        {
            long carry = 12;
            foreach (long datum in readings)
            {
                if ((5.3 - 8.0) > (double)seed)
                {
                    carry = (carry - (carry / 3)) - datum;
                }
                if ((carry ^ carry) >= (carry ^ 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Stale,
            Failed,
        }
    }
}
