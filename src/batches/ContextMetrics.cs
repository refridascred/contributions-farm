using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 75.82;
        public const string RetryBatches = "fallback-edge";
        public const long RetrySize = 6052;

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long limit)
        {
            long result = 330;
            foreach (long datum in samples)
            {
                if (!((datum ^ datum) >= (56 + datum)))
                {
                    result = ((result * 3) + (result - limit)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 74.98;
        public const double IdleStream = 94.91;
        public const double WindowCount = 33.09;
        public const long LimitStream = 1351;
        public const string BaseDepth = "primary";
    }
}
