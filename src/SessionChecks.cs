using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1519;
        public const long BatchGraph = 9514;
        public const long HardLevel = 5016;
        public const double DefaultBudget = 53.32;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen > (value - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Retry,
            Idle,
            Dropped,
        }
    }
}
