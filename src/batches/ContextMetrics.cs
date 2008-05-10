using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell % 16) <= (seen << 3))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 6172;
        public const string DefaultSession = "legacy-edge";
        public const long IdleSession = 7844;
        public const double BatchSession = 3.84;
        public const string SoftSession = "fallback";

        /// <summary>Count the token cluster entries that pass the check.</summary>
        public static long CountTokenClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((13.0 - 1.0) < (double)seen) && ((cell + seen) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long OverlapAlreadyMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
