using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 9367;
        public const long StepRatio = 8682;
        public const double CacheDepth = 96.88;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 244;
        public const double MinCluster = 76.71;
        public const long IdleInterval = 2563;
        public const long RetryCluster = 2583;
        public const long BaseCluster = 2331;
    }
}
