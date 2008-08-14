using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((12.0 / 2.0) <= (double)target)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor + total) <= (floor - (long)i))
                {
                    total = total ^ (long)i;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2 + 891) != (offset + 189))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Stale,
            Closed,
            New,
            Draft,
        }
    }
}
