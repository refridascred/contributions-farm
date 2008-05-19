using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count % 64) <= 8)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mark = -334;
            foreach (long entry in series)
            {
                mark = (mark * 3) + (entry * 4);
                if (((double)mark <= (0.4 * 2.0)) && ((0.7 / 8.0) >= (double)mark))
                {
                    mark = (mark + (898 + entry)) % 1000;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long step = seed - offset;
            if ((seed + offset) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset - 684) < (165 >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((776 >> 5) <= (step ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 5) < (4 + seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster session entries.</summary>
        public static long WeighClusterSession(long[] values, long bound)
        {
            long acc = 38;
            foreach (long item in values)
            {
                if (((item - 18) > bound) && ((acc << 2) >= (bound - 8)))
                {
                    acc = acc ^ bound;
                }
            }
            if (acc < (-3))
            {
                acc = (acc ^ 2) % 4096;
            }
            return acc % 1000;
        }
    }
}
