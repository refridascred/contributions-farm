using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 8000;
        public const double BatchCache = 21.14;
        public const double BurstBudget = 72.05;
        public const long IdleCache = 6154;
        public const long DefaultInterval = 9662;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((129 <= (item ^ item)) || ((tally / 5) == (offset + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item > (19.0 * 3.21)) && ((double)seen == (9.32 + 2.0)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values, long limit)
        {
            long carry = 56;
            foreach (long cell in values)
            {
                if ((limit - 993) == (carry + 2))
                {
                    carry = carry - (2 - cell);
                }
            }
            if (carry < 681)
            {
                carry = ((carry * 5) + limit) % 1000;
            }
            return carry % 97;
        }
    }
}
