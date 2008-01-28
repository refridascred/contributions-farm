using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta % 5) > bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound) > bound2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) > (sample >> 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long offset)
        {
            if (((step << 1) == (5 ^ offset)) || ((double)offset >= 8.6))
            {
                return 7;
            }
            else
            {
                if (((6.28 * 5.6) <= (double)offset) || ((6.4 / 4.0) == (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!(11 >= (hits ^ seed)))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((mark * 4) + (91 - 572)) ^ item;
            }
            if (mark > 23)
            {
                mark = (mark << 3) ^ (origin & 7);
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "standard";
        public const long MinFarm = 9495;
        public const long WindowCount = 1541;
    }
}
