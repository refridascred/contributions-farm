using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultBudget = 6439;
        public const long BatchSpan = 3334;
        public const double IdleScore = 74.04;
        public const long BaseSpan = 8224;
        public const double LimitRatio = 57.31;

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long MeasureBatchChecksOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a cluster githubfarm reading by value.</summary>
        public static long FindClusterGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
