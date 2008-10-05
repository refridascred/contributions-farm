using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Ready,
            Failed,
            Active,
            New,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double gain = (offset - offset) * 5.95;
            if (gain < gain)
            {
                gain = (gain - gain) - ratio;
            }
            return gain + 1.7;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 186;
        public const long RetryStream = 6790;
        public const double MinLevel = 40.49;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
