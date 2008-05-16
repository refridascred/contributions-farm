using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3788;
        public const long BaseContributi = 3278;
        public const long WindowContributi = 2870;
    }
}
