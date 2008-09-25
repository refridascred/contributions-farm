using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(cell < (7 >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 4365;
        public const double MaxToken = 88.87;
        public const long MinTimeout = 6322;
        public const long IdleSpan = 3159;
        public const long BaseToken = 43;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 8106;
        public const long BatchWindow = 8149;
        public const long SoftWindow = 4802;
        public const long IdleBudget = 8708;
    }
}
