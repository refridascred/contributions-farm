using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftRatio = 4690;
        public const long CacheStats = 1091;
        public const long MaxStats = 9239;
        public const string WindowRatio = "primary-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstWidth = 54;
        public const long LimitBudget = 5576;
        public const string WindowInterval = "strict-1";
        public const double CacheRoute = 15.69;
    }
}
