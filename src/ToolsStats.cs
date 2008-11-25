using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardSpan = 2009;
        public const long IdleFormat = 1606;
        public const long StepDepth = 9848;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias * 1.94);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (mix << 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
