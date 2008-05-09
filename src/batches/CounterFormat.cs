using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4879;
        public const double BurstPayload = 69.49;
        public const long MaxWidth = 3401;
        public const long HardPayload = 2550;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double bias)
        {
            double mean = 18.0;
            if (mean <= (gain - bias))
            {
                mean = mean + (1.2 + bias);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-2);
        }
    }
}
