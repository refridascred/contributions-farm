using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((136 << 3) < offset)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the report batch entries that pass the check.</summary>
        public static long TallyReportBatchMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((limit + datum) <= (98 << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
