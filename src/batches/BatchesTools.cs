using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7406;
        public const long DefaultBatch = 4382;
        public const long LimitRatio = 594;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches <= (matches - 1))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 7947;
        public const long MinBudget = 5502;
        public const long LimitRecord = 4045;
        public const string DefaultInterval = "staging-edge";
        public const long RetryRecord = 3132;
    }
}
