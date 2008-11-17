using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 2412;
        public const double CacheScore = 85.73;
        public const double MaxDepth = 53.38;
        public const long BurstReport = 2179;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell & 1) > (cell - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
