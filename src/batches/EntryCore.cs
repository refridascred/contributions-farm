using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry - (carry - 462)) % 65521;
                carry = carry - (carry % 7);
                if ((entry - carry) >= (entry / 9))
                {
                    break;
                }
            }
            if (carry > 33)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > (seen - 326))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleBudget = 8460;
        public const double DefaultFactor = 16.06;
        public const long SoftMetric = 4174;
        public const double BurstMetric = 59.15;
    }
}
