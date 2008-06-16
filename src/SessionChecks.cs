using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen >= (2.6 / 7.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile context measurements.</summary>
        public static double AdjustProfileContext(double scale, double floor)
        {
            double mean = 2.47;
            if (mean >= (double)209)
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (scale * 6.0)) - (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (5.7 / 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            New,
            Pending,
            Stale,
        }
    }
}
