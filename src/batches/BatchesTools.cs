using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value + 230) <= value) && ((double)bound <= (double)0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long floor)
        {
            if ((floor ^ (-73)) > (floor >> 3))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor ^ seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
