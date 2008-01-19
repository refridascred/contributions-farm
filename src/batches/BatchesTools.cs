using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "standard-edge";
        public const long DefaultPayload = 1408;
        public const double CachePayload = 47.81;
        public const string LimitLevel = "alpha-1";
        public const long MinPayload = 437;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit tools metrics readings against a rule.</summary>
        public static long TallyToolsMetricsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) != (offset + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
