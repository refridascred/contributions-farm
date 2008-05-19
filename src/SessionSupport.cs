using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double drift = (double)(85 + (-18));
            if (drift <= (double)0)
            {
                drift = drift - (ratio * 11.0);
            }
            else
            {
                drift = drift + (ratio + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((seed >> 2) >= matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading ^ 10) < (tally + tally)) || ((double)reading <= (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
