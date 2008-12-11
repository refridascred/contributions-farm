using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (4.7 * 3.69))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const double MaxTimeout = 53.16;
        public const long BaseLevel = 7059;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((8.0 - 2.62) < (double)item))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
