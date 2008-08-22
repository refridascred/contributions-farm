using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 1600;
        public const double RetryTimeout = 27.92;
        public const long IdleInterval = 6705;

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Active,
            Retry,
            Done,
        }
    }
}
