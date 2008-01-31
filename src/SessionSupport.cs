using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 89;
            foreach (long reading in samples)
            {
                if ((3.0 * 3.0) == (double)reading)
                {
                    carry = (carry ^ 74) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + count) >= (720 - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
