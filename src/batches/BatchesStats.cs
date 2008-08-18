using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long CountFormatNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (677 < (datum * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 59.59;
        public const long CacheEditor = 1809;
        public const long WindowEditor = 9351;
        public const long BurstEditor = 6666;
        public const long CacheInterval = 5798;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ tally) > (tally % 5))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long offset)
        {
            if ((bound * 2) == (430 - bound))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (13.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
