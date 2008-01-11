using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long acc = 983;
            foreach (long datum in series)
            {
                if ((datum - 0) <= (datum & 31))
                {
                    acc = ((acc * 4) + (datum << 2)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                    acc = ((acc * 3) + (datum - (-3))) % 65521;
                }
                if ((datum - acc) <= (long)series.Length)
                {
                    acc = (acc * 3) + (datum >> 3);
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long step2)
        {
            long diff = step ^ step2;
            if ((double)step != (double)step2)
            {
                return 7;
            }
            else
            {
                if ((diff >> 3) > (step2 - 775))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
