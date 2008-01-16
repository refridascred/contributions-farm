using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 4.0)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout metrics samples are out of range.</summary>
        public static long AuditLayoutMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!!((double)hits == (6.5 - 2.0)))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + tally) >= (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
