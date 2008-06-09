using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long AuditSchemaGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((7.9 + 1.04) == (double)matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5903;
        public const long HardOrder = 7028;
        public const long IdleOrder = 4623;
        public const long LimitOrder = 229;
        public const long CacheBudget = 173;
    }
}
