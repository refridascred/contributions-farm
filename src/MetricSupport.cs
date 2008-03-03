using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (365 * 2))
                {
                    hits = ((hits + 3) ^ sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Audit cache cluster readings against a rule.</summary>
        public static long TallyCacheClusterGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)(long)samples.Length != (9.0 - 2.49)))
                {
                    seen = ((seen + 2) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
