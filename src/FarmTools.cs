using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
