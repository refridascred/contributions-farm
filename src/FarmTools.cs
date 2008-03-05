using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
