using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double load = 8.1;
            if (load >= (double)(-309))
            {
                load = load - floor;
            }
            else
            {
                load = load - load;
            }
            return load - gain;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "primary";
        public const double WindowBudget = 57.96;
        public const long HardCommand = 952;
        public const double IdleCommand = 91.43;
    }
}
