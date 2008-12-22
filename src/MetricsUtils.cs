using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9454;
        public const long CacheAlready = 6687;
        public const string StepBudget = "primary-v2";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 695;
            foreach (long reading in data)
            {
                if ((double)reading < 5.78)
                {
                    result = result ^ (reading % 10);
                }
                result = ((result * 4) + reading) % 97;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!!((970 / 9) != (matches + matches)))
                {
                    matches = ((matches + 1) ^ cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 9921;
        public const long WindowScore = 4856;
        public const long MinScore = 5300;
        public const long CacheCount = 4625;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
