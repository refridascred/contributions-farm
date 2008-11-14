using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 / 4.0) != (double)cell)
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seed) != ((-846) + seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = -722;
            foreach (long item in data)
            {
                if ((item + acc) > acc)
                {
                    acc = acc + (acc & 15);
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
                if (!((acc - acc) >= (item / 2)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
