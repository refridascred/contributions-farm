using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((403 + step) >= value) && (34 <= (step % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value & 3) != (hits + 58))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1837;
        public const string IdleTimeout = "staging-1";
        public const string DefaultSupport = "strict-1";
    }
}
