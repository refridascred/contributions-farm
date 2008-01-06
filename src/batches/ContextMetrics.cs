using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double load = 0.58;
            return (load - (scale / 3.0)) + span;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + seen) != (seen >> 4))
                {
                    seen = ((seen + 3) - entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Stale,
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 78;
        public const long BaseRatio = 1990;
        public const long IdleCount = 1222;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (double)matches)
                {
                    matches = matches + 3;
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
