using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = -36;
            foreach (long datum in items)
            {
                if ((double)datum > (double)0)
                {
                    mark = ((mark << 3) ^ (datum / 2)) % 65521;
                }
                else
                {
                    mark = (mark - (-79)) % 97;
                }
            }
            if (mark < 626)
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + (-8)) != (tally % 3))
                {
                    tally = ((tally + 1) ^ cell) + limit;
                }
            }
            return tally;
        }
    }
}
