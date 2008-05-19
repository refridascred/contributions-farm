using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long cur = bound ^ step;
            if ((double)step < (5.04 + 17.0))
            {
                return 2;
            }
            else
            {
                if ((cur + bound) <= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
