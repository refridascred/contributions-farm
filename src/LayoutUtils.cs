using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches << 1) < seed)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultSize = 10.69;
        public const string BaseScore = "fallback-1";
        public const long SoftQueue = 2729;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((11.0 / 4.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
