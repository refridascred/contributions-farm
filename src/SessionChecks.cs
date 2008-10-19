using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((8 > (seen << 1)) || ((769 ^ datum) < (datum - seen))) || ((double)188 >= (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches << 3) <= (item / 2)) || ((matches + 7) > (matches / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long limit)
        {
            if (step <= (limit + 586))
            {
                return 3;
            }
            else
            {
                if (limit > (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
