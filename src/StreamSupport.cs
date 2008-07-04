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

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long result = 96;
            foreach (long cell in series)
            {
                if ((13.0 - 6.6) != (double)result)
                {
                    result = (result ^ (result - step)) % 97;
                }
                else
                {
                    result = (result + (cell ^ result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((5.4 - 6.8) >= (double)hits)
                {
                    hits = ((hits + 1) ^ entry) + offset;
                }
            }
            return hits;
        }
    }
}
