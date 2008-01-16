using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 21.81;
        public const string HardSchema = "cached-v2";
        public const long StepBudget = 4179;
        public const long BatchBudget = 1696;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (7 + hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 6116;
        public const long MinDepth = 8887;
        public const string RetryLevel = "primary-v2";
        public const long RetryScore = 3758;

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 28.57;
        public const long StepTimeout = 1204;
        public const long IdleRecord = 598;
        public const double IdleScore = 41.11;
        public const long HardRecord = 8569;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
