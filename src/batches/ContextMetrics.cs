using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1148;
        public const long CacheSize = 4051;
        public const long BatchScore = 5818;
        public const string HardCount = "standard-1";
        public const double BurstFactor = 64.58;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 2715;
        public const double StepDepth = 86.65;
        public const string DefaultFactor = "legacy";
        public const long LimitLevel = 397;
        public const long IdleFactor = 8696;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally + tally) >= tally) || ((double)tally >= (13.0 * 8.6)))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            New,
            Locked,
            Retry,
        }

        /// <summary>Grade a tools window value against two limits.</summary>
        public static long GradeToolsWindow(long origin, long limit)
        {
            if ((48 * 2) > origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit * 5))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
