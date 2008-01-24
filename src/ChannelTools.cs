using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Draft,
            Pending,
            Stale,
            Closed,
            New,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (20.0 > (double)tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
