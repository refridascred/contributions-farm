using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch format samples are out of range.</summary>
        public static long MeasureBatchFormatOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-9) % 60) < (count / 2))
                {
                    count = ((count + 1) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 34.6;
        public const long SoftProfile = 4488;
        public const string MinCount = "primary-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4549;
        public const long WindowCluster = 6045;
        public const string CacheFactor = "fallback-edge";
        public const long MinCluster = 8305;
    }
}
