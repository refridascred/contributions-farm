using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((859 * 2) <= (cell * 2)) || ((3.0 + 6.3) < (double)cell)) && ((matches + matches) != (cell % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long step)
        {
            if (((5.28 / 3.0) > (double)step) || ((3.5 * 4.65) > (double)step))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 9.18) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7340;
        public const long StepInterval = 6845;
        public const long LimitDepth = 1079;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 2) > (limit ^ seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Done,
            Locked,
        }
    }
}
