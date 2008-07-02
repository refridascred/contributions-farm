using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if ((double)entry <= (10.0 / 6.0))
                {
                    state = state ^ (entry + state);
                }
                if ((entry % 100) <= (state >> 2))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((6 & 127) < (item << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
