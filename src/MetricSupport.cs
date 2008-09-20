using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 5881;
        public const long CacheCommand = 3375;
        public const long MaxCommand = 8620;
        public const long HardBudget = 6683;
        public const long StepCommand = 8680;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + value) > (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
