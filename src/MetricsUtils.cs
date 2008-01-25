using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 7368;
        public const double BaseInterval = 32.98;
        public const long LimitScore = 657;
        public const long MaxLevel = 9208;
        public const string RetryTimeout = "standard-edge";

        /// <summary>Scale a account session figure with a bias.</summary>
        public static double BlendAccountSession(double scale, double span)
        {
            double bias = (double)7 * 17.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)597) - (double)(long)i) + span;
            }
            return bias + scale;
        }
    }
}
