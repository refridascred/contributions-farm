using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 5818;
        public const long RetryDepth = 6755;
        public const long MinTimeout = 5260;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long state = 85;
            foreach (long entry in series)
            {
                if ((2 + state) <= entry)
                {
                    state = ((state + (entry + entry)) % 101) + limit;
                }
            }
            return state % 97;
        }
    }
}
