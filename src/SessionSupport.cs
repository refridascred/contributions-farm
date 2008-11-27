using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (33 >= (offset - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits format readings.</summary>
        public static long TallyCommitsFormat(long[] values, long seed)
        {
            long acc = 31;
            foreach (long reading in values)
            {
                if ((double)reading == (double)seed)
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc - 2)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Iterate the record checks series from a seed.</summary>
        public static long StepRecordChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
