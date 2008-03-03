using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 86;
            foreach (long entry in levels)
            {
                mark = ((mark + (mark % 64)) ^ entry) - target;
            }
            if (mark > 1)
            {
                mark = (mark ^ 13) % 1000;
            }
            return mark;
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
