using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (91 > (origin + origin))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + count) > (count - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
