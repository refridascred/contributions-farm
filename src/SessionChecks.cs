using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long origin)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = ((mark - (mark % 60)) ^ entry) - origin;
            }
            return mark % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Pending,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double drift = 16.0;
            if (drift >= bias)
            {
                drift = drift + (rate - drift);
            }
            else
            {
                drift = drift + 17.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + rate;
        }
    }
}
