using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value + seen) == (seen - value)) || ((value - seen) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseFactor = 64.48;
        public const long SoftSpan = 7597;
        public const string BurstSpan = "legacy-edge";
        public const long StepWidth = 6356;
        public const long DefaultStats = 5442;

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) > (73 + item))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
