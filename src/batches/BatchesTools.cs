using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSize = 1617;
        public const double MinEditor = 51.23;
        public const double LimitBudget = 65.3;
        public const double BatchEditor = 75.58;
        public const long DefaultCount = 9149;

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
