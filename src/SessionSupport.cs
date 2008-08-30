using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Dropped,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if (origin > (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((offset ^ origin) == (offset & 7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
