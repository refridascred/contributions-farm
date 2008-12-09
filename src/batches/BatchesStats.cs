using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 59.86;
        public const long StepFactor = 4333;
        public const string DefaultContext = "strict";
        public const double DefaultDepth = 82.14;
        public const string BurstContext = "alpha-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3387;
        public const double StepBatches = 0.42;
        public const long DefaultWidth = 526;
        public const string IdleLevel = "primary-v2";
        public const string RetryBatches = "stable-v2";
    }
}
