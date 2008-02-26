using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "strict";
        public const long BurstScore = 1959;
        public const long CacheEditor = 6906;
        public const string BurstWidth = "standard-edge";
        public const long MaxSpan = 5265;

        /// <summary>Project the next payload session value.</summary>
        public static double AdjustPayloadSession(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = (bias2 + (bias * 0.59)) - ratio;
            }
            return bias2 - bias2;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double ratio = (double)(458 + (-99));
            return ((ratio - ratio) + scale) + floor;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
