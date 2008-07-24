using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "alpha-1";
        public const long LimitTools = 3196;
        public const long MaxTools = 187;
        public const string SoftTools = "open-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8419;
        public const long BatchBudget = 5174;
        public const double BaseWidth = 93.42;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 31) >= ((long)series.Length + target))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
