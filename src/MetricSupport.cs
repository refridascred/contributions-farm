using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 3858;
        public const long HardRecord = 1621;
        public const long RetryRecord = 4126;
        public const double MaxTimeout = 74.64;
        public const long MaxFactor = 8004;

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
