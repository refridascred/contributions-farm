using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double load = (double)(3 << 2);
            return ((load + (double)309) + gain) + offset;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
