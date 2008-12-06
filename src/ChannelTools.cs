using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (13.0 * 3.3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen ^ cell) > (origin ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
