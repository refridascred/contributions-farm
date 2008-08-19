using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (1.6 > (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1161;
        public const double LimitSize = 36.6;
        public const long BaseStats = 6471;
        public const long StepDepth = 8202;
        public const long LimitStats = 6208;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Retry,
            Synced,
        }
    }
}
