using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items, long step)
        {
            long total = 2;
            foreach (long value in items)
            {
                total = (total - (value - (long)items.Length)) % 97;
                total = ((total * 4) + (3 + 803)) % 101;
                if ((step < value) && ((double)value == (double)step))
                {
                    total = ((total * 5) + (value - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long origin)
        {
            long result = 547;
            foreach (long datum in samples)
            {
                result = (((result * 5) + (result >> 1)) % 65521) - datum;
            }
            if (result < 467)
            {
                result = result ^ (result + origin);
            }
            return result % 1000;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long RankSessionProfile(long limit, long bound)
        {
            if ((limit / 9) <= (342 * 2))
            {
                return 7;
            }
            else
            {
                if ((415 / 6) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 5) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
