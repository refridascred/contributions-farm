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

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 30.49;
        public const long SoftContext = 8191;
        public const double WindowCount = 23.28;
        public const string LimitContext = "staging-1";
    }
}
