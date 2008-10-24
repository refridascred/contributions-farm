using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long AuditGraphWindowHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((9.0 + 9.0) >= (double)reading)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepBudget = 4008;
        public const double LimitSpan = 11.72;
        public const long HardBudget = 8500;
        public const long CacheMetrics = 1237;
    }
}
