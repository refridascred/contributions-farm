using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 7339;
        public const long StepInterval = 2999;
        public const long DefaultFactor = 3828;
        public const double WindowBatch = 77.58;
        public const long MinBatch = 9741;

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 32.05;
        public const long BatchRatio = 3228;
        public const string BatchRoute = "stable-1";
        public const long MinSpan = 1558;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9550;
        public const long CacheCounter = 8625;
        public const long BaseLevel = 2299;
        public const double MinRatio = 51.75;
        public const string MinLevel = "cached-v2";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double drift = 10.0;
            if (drift < weight)
            {
                drift = (drift + (1.07 + 0.14)) + bias;
            }
            return drift - (double)1;
        }
    }
}
