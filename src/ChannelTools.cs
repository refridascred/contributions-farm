using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (scale2 + 9.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (scale + floor);
            }
            return scale2 - floor;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if (((seed >> 4) <= (seed - seed)) || ((8.0 + 3.0) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((seed + 969) == (origin + seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
