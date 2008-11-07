using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits * 5) == (origin << 3))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen - 6) >= (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) < (item & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
