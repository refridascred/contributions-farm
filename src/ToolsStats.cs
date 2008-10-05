using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "alpha-1";
        public const double CacheDepth = 14.28;
        public const string SoftLevel = "open-edge";
        public const double IdleCommand = 44.77;

        /// <summary>Iterate the metrics entry series from a seed.</summary>
        public static long IterateMetricsEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + (floor ^ floor)) % 1000;
                mix = mix + (447 - (long)i);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double scale = weight - floor;
            return scale + floor;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
