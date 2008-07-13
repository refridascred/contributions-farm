using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits >= (6.0 - 9.0))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Closed,
            Retry,
            New,
            Locked,
        }

        /// <summary>Count the payload buffer entries that pass the check.</summary>
        public static long AuditPayloadBufferGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((3.9 - 6.81) <= (double)value) || (value < (step + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
