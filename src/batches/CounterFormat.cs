using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two batches session measurements.</summary>
        public static double BlendBatchesSession(double weight, double offset)
        {
            double ratio = weight - (5.0 / 3.0);
            if (ratio <= ratio)
            {
                ratio = ratio - offset;
            }
            return ratio - weight;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3550;
        public const double SoftCount = 37.76;
        public const long BaseDepth = 1950;
        public const long StepFactor = 4639;
        public const double StepWidth = 5.43;
    }
}
