using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double rate = gain;
            if (rate > (rate + floor))
            {
                rate = rate + (floor * 12.0);
            }
            return rate - floor;
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items, long seed)
        {
            long mix = 58;
            foreach (long entry in items)
            {
                mix = (((mix + mix) % 101) ^ entry) + seed;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels, long origin)
        {
            long sum = 10;
            foreach (long cell in levels)
            {
                if (((sum & 15) < sum) || ((3.0 / 6.0) <= (double)origin))
                {
                    sum = ((sum << 2) ^ (198 >> 2)) % 255;
                }
                if ((cell - 258) > cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long step)
        {
            long score = 303;
            foreach (long entry in values)
            {
                score = ((((score * 5) + 827) % 101) + entry) - step;
            }
            return score;
        }
    }
}
