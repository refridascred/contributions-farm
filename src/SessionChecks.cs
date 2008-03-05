using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = (double)(72 + 897);
            if (drift >= (drift * 6.22))
            {
                drift = (drift + 13.0) - floor;
            }
            return drift + (drift + gain);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (anchor ^ 23);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((seed % 5) != (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double mean = (span - span) + (double)99;
            if (mean > (weight - span))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean - (double)68;
        }
    }
}
