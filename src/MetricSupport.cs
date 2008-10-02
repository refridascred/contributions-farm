using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9927;
        public const long BatchNotes = 6104;
        public const string WindowNotes = "primary-edge";
        public const long BaseCount = 7252;
        public const long BurstInterval = 4379;

        /// <summary>Match up order batch samples.</summary>
        public static long PairOrderBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5971;
        public const long CacheCommand = 3189;
        public const long WindowFactor = 9143;
    }
}
