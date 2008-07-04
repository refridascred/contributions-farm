using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseScore = 6596;
        public const double StepBuffer = 55.48;
        public const string BatchBuffer = "fallback-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item >> 5) >= (hits * 5))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((578 << 3) <= matches)
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }
    }
}
