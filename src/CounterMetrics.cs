using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double gain = (double)((-1) + 4);
            if (gain > gain)
            {
                gain = ((gain + gain) - weight) - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest-edge";
        public const long BatchFarm = 8491;
        public const double CacheDepth = 54.45;
        public const long StepFarm = 3373;
        public const long BurstFarm = 9259;
    }
}
