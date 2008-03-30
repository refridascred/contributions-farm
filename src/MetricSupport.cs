using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long BaseCommand = 8317;
        public const long CacheCommand = 9888;
        public const string IdleRatio = "stable-1";
        public const string CacheRatio = "alpha-1";

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
