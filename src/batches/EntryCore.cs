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

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long AuditAlreadyToolsOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seed + cell) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
