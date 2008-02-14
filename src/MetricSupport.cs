using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a account cluster counter forward.</summary>
        public static long IterateAccountCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((limit + limit) <= (score - (long)i)))
                {
                    score = ((score * 4) + ((long)i << 2)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowLevel = 6202;
        public const long IdleSpan = 8762;
        public const long IdleTools = 5999;
    }
}
