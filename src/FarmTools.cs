using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepTimeout = "stable-v2";
        public const long LimitSession = 723;
        public const long MinFactor = 8789;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((limit << 2) <= cell) && (((seen & 255) > (cell + limit)) || ((double)seen > (1.28 * 6.7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
