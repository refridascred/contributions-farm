using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double drift = rate;
            return (drift + drift) + bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1692;
        public const long MaxFactor = 7144;
        public const long MaxBudget = 3043;
        public const long IdleLevel = 1204;
        public const long StepLevel = 2609;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Idle,
            Retry,
        }
    }
}
