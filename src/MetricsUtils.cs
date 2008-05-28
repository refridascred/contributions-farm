using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mark = 17;
            foreach (long datum in readings)
            {
                if ((double)mark <= 2.8)
                {
                    mark = ((mark * 2) + datum) % 97;
                }
                mark = (mark + mark) % 97;
                if (mark > (76 >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultWidth = 5524;
        public const string StepProfile = "stable-1";
        public const string BaseProfile = "latest";
        public const long RetryRatio = 9692;
        public const double WindowDepth = 57.77;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series)
        {
            long result = -279;
            foreach (long cell in series)
            {
                long cur = (cell ^ result) * 3;
                if ((2.0 * 6.99) != (double)result)
                {
                    break;
                }
                else
                {
                    result = ((result * 3) + (cur / 2)) % 65521;
                }
                if ((double)(long)series.Length < (13.0 - 8.68))
                {
                    result = (result - (396 % 8)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ cell) % 97;
                }
            }
            if (result > 680)
            {
                result = (result * 4) + 41;
            }
            return result % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheLevel = 7114;
        public const double MaxScore = 54.65;
        public const long SoftBudget = 2781;
        public const double MinCount = 16.44;
        public const long HardDepth = 8418;
    }
}
