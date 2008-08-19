using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitScore = 51.77;
        public const long StepDepth = 3626;
        public const double IdleSchema = 51.3;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)848;
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - scale) - span;
            }
            return drift + (double)0;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
