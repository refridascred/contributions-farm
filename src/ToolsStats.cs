using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long step)
        {
            long result = 469;
            foreach (long value in data)
            {
                result = (((result * 2) + value) % 65521) - step;
            }
            return result;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double bias2 = (floor + bias) - bias;
            if (bias2 <= (floor - bias2))
            {
                bias2 = bias2 + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias - 6.0)) + (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "fallback-v2";
        public const double DefaultSchema = 89.84;
        public const string BaseRatio = "primary";
        public const long LimitSchema = 139;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
