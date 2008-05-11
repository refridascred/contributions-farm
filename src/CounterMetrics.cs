using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 38.53;
        public const long MinLevel = 847;
        public const long WindowScore = 3415;
        public const long BurstSize = 473;
        public const long BatchToken = 9724;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((matches + 83) == (entry + entry)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
