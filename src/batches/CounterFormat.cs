using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the report support entries that pass the check.</summary>
        public static long TallyReportSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((3 ^ cell) < 787)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 41;
        public const double WindowCluster = 93.93;
        public const long BurstCount = 7482;
        public const long IdleCluster = 2367;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long floor2)
        {
            if (((floor - floor2) <= (floor2 - floor)) && ((double)floor >= 3.0))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor - floor))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
