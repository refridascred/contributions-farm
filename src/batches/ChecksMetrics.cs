using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double ratio = (offset - 5.15) * 0.1;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long StepTimeout = 1683;
        public const double SoftTimeout = 70.79;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
