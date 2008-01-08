using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context format readings against a rule.</summary>
        public static long MeasureContextFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
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
