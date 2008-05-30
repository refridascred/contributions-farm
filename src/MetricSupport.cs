using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of buffer farm readings.</summary>
        public static long OverlapBufferFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 8253;
        public const string SoftAccount = "legacy-edge";
        public const string SoftSpan = "legacy-1";
        public const long BurstWidth = 4243;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepScore = 407;
        public const double CacheInterval = 38.08;
        public const double SoftCount = 31.08;
    }
}
