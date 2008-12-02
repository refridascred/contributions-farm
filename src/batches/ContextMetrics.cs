using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchInterval = "stable-1";
        public const long WindowBudget = 634;
        public const long StepPayload = 2164;

        /// <summary>Audit channel commits readings against a rule.</summary>
        public static long MeasureChannelCommitsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) != (reading % 2))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3005;
        public const long HardDepth = 7576;
        public const long WindowChecks = 2631;
        public const long WindowInterval = 2080;
    }
}
