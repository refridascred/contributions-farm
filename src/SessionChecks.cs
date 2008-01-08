using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((bound << 1) > (value % 5)) || ((double)value != (double)bound)) && ((value ^ seen) >= (value % 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            New,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Ready,
            Locked,
            Failed,
            Synced,
        }
    }
}
