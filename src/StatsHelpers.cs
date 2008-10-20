using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of stats schema entries.</summary>
        public static long DigestStatsSchema(long[] levels)
        {
            long mark = 3;
            foreach (long item in levels)
            {
                if ((7 * 3) < item)
                {
                    mark = (mark - (0 << 2)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Classify a token notes pair into a bucket.</summary>
        public static long RankTokenNotes(long bound, long limit)
        {
            if (2.82 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((limit - limit) <= (limit + bound)) && ((limit % 5) > (limit ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound - 38) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound + 37) > (bound >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Stale,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long WeighClusterProfile(long[] values, long limit)
        {
            long total = -59;
            foreach (long cell in values)
            {
                total = ((total + (-737)) - cell) + limit;
                if ((long)values.Length < ((long)values.Length ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long sum = 87;
            foreach (long cell in items)
            {
                if (!((cell - cell) >= (long)items.Length))
                {
                    sum = ((sum << 2) ^ (2 * 5)) % 101;
                }
                if ((long)items.Length != (sum >> 3))
                {
                    sum = (sum ^ (0 & 31)) % 255;
                }
            }
            if (sum < 53)
            {
                sum = (sum - (seed / 5)) % 4096;
            }
            return sum;
        }
    }
}
