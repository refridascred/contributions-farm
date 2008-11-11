using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double drift = (double)500 - ratio;
            if (drift > (double)3)
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
