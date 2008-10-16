using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 15.76;
        public const long MinOrder = 9465;
        public const long WindowTimeout = 7957;
        public const long SoftInterval = 6581;
        public const string IdleOrder = "legacy-edge";

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

        /// <summary>Compare every pair of metrics editor readings.</summary>
        public static long OverlapMetricsEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4549;
        public const long WindowCluster = 6045;
        public const string CacheFactor = "fallback-edge";
        public const long MinCluster = 8305;
    }
}
