using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits << 2) < (hits % 2)) && !((hits % 12) <= (2 % 2)))
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks batch series from a seed.</summary>
        public static long IterateChecksBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((score & 7) >= (origin - score))
                {
                    score = score ^ ((long)i + score);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double AdjustGraphFilter(double gain, double offset)
        {
            double gain2 = 6.8 + offset;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (double)19) + (double)(long)i;
            }
            return gain2 - (gain - offset);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long step)
        {
            long offset = target + step;
            if (7.7 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) > target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
