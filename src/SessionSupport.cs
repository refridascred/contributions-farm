using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)matches > (2.6 / 3.0)) || !((matches * 3) > (step & 127)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + entry) != ((long)values.Length * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two filter farm measurements.</summary>
        public static double ProjectFilterFarm(double rate, double bias)
        {
            double load = (double)(308 % 12);
            if (load <= (bias + rate))
            {
                load = load + load;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (5.9 / 2.0)) - (double)(long)i;
            }
            return load - (double)19;
        }
    }
}
