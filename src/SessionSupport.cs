using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            long step = limit ^ floor;
            if (!((limit ^ step) >= (step + limit)))
            {
                return 6;
            }
            else
            {
                if ((step * 4) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((2.0 - 1.44) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Done,
            Queued,
            Active,
        }
    }
}
