using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long LocateAccountPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
