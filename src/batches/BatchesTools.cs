using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] readings, long step)
        {
            long state = 111;
            foreach (long value in readings)
            {
                if ((state >> 4) <= step)
                {
                    state = ((state << 2) ^ (562 + value)) % 101;
                }
                if ((double)value != (7.57 * 2.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if (!!((step >> 2) > (6 << 1)))
                {
                    mark = (mark << 2) ^ (step - step);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long AuditCounterChecksMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (double)hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }
    }
}
