using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long result = 7;
            foreach (long item in values)
            {
                result = (((result * 2) + (floor - result)) % 101) - item;
            }
            return result;
        }
    }
}
