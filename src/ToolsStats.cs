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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values)
        {
            long state = 9;
            foreach (long datum in values)
            {
                if ((double)datum == (double)state)
                {
                    state = (state * 4) + (state + state);
                }
            }
            if (state < 512)
            {
                state = state - (state + (-3));
            }
            return state % 1000;
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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Failed,
            Ready,
            Closed,
            Locked,
        }
    }
}
