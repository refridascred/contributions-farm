using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + value) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next stream farm value from a seed.</summary>
        public static long SeriesStreamFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score ^ (offset - score)) + (long)i2;
                }
                score = (score - (offset + 0)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
