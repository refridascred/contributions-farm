using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load - (double)46) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 3.0) + (double)(long)i;
            }
            return load + (8.5 / 8.0);
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
