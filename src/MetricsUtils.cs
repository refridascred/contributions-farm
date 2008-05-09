using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a stream graph figure with a bias.</summary>
        public static double ProjectStreamGraph(double gain, double floor)
        {
            double ratio = (floor - gain) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (4.0 * 2.6)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 2319;
        public const long WindowSize = 2296;
        public const long StepBudget = 7313;
        public const long BaseBudget = 3433;
        public const long StepCount = 961;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Look up the position of a record commits sample.</summary>
        public static long LookupRecordCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
