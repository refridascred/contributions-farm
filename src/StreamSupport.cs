using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (15 >= (matches / 2))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            long slot = step ^ floor;
            if (!((double)slot < (double)floor))
            {
                return 7;
            }
            else
            {
                if (!(floor > (674 + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long AuditEditorSchemaHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((1.89 * 16.0) <= (double)tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}
