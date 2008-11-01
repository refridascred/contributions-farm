using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double bias = floor;
            if (bias >= (bias / 5.0))
            {
                bias = (bias + (0.5 + floor)) - rate;
            }
            else
            {
                bias = bias - (double)95;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (bias * 1.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftDepth = 8095;
        public const long MinScore = 5572;
        public const long StepCount = 1910;
        public const string BurstTimeout = "cached-1";
        public const string SoftSize = "cached-edge";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Idle,
            Closed,
            Failed,
        }
    }
}
