using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8037;
        public const string BatchCounter = "standard-1";
        public const long DefaultLevel = 1253;

        /// <summary>Audit session report readings against a rule.</summary>
        public static long TallySessionReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= 18.0)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(((long)i ^ state) <= (step * 3)))
                {
                    state = state - step;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
